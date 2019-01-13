using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary1.Enums;
using ClassLibrary1.Models;

namespace Employees.Domain.Repositories
{
	public class EmployeeRepository
	{
		public List<Employee> Employees;

		public EmployeeRepository()
		{
			Employees = new List<Employee>()
			{
				new Employee("Jure", "Radalj", "123456", WorkPosition.Developer, new DateTime(1993, 12, 23)),
				new Employee("Petra c", "Peslac", "987654", WorkPosition.Secretary, new DateTime(1994, 12, 20)),
				new Employee("kristian", "zolo", "122122", WorkPosition.Manager, new DateTime(1994, 3, 20)),
				new Employee("Skylar", "White", "984123", WorkPosition.Accountant, new DateTime(1968, 10, 11)),
				new Employee("Duje", "mihanovic", "109983", WorkPosition.WebDeveloper, new DateTime(1985, 1, 9))
			};
		}

		public bool IsEmployeeValid(Employee employeeToAdd)
		{
			foreach (var employee in Employees)
				if (employee.Oib == employeeToAdd.Oib || employeeToAdd.DateOfBirth.AddYears(18) > DateTime.Now)
					return false;
			return true;
		}

		public string Add(Employee employeeToAdd, ProjectRepository projectRepository,
			List<ProjectWithWorkHours> projectWithWorkHours)
		{
			employeeToAdd.ProjectWithWorkHours = projectWithWorkHours;
			if (!IsEmployeeValid(employeeToAdd))
			{
				return "That oib is already added.";
			}

			if (!employeeToAdd.IsOibValid())
			{
				return ("Oib contains letters and doesn't have 11 characters.");
			}

			Employees.Add(employeeToAdd);
			foreach (var project in projectRepository.Projects)
			{
				foreach (var projectWithWorkHoursItem in projectWithWorkHours)
				{
					if (projectWithWorkHoursItem.Project.Name == project.Name)
					{
						var employeeWithWorkHours1 = new EmployeeWithWorkHours();
						employeeWithWorkHours1.Employee = employeeToAdd;
						employeeWithWorkHours1.WorkHours = projectWithWorkHoursItem.WorkHours;
						project.EmployeeWithWorkHours.Add(employeeWithWorkHours1);
					}
				}
			}

			return null;
		}

		public string Delete(Employee employeeToDelete, ProjectRepository projectRepository)
		{
			foreach (var project in projectRepository.Projects)
			{
				foreach (var projectWithWorkHours in employeeToDelete.ProjectWithWorkHours.ToList())
				{
					if (project.Name == projectWithWorkHours.Project.Name)
					{
						if (project.EmployeeWithWorkHours.Count == 1)
						{
							return "You can't delete this employee because project has only this selected employee";
						}
						else
						{
							employeeToDelete.ProjectWithWorkHours.Remove(projectWithWorkHours);
							foreach (var employeeWithWorkHours in project.EmployeeWithWorkHours)
							{
								if (employeeWithWorkHours.Employee.Oib == employeeToDelete.Oib)
								{
									project.EmployeeWithWorkHours.Remove(employeeWithWorkHours);
									break;
								}
							}
						}
					}
				}
			}

			Employees.Remove(employeeToDelete);
			return null;
		}

		public string Edit(Employee employeeToEdit, ProjectRepository projectRepository,
			List<ProjectWithWorkHours> projectWithWorkHours)
		{
			var projectsToAdd = employeeToEdit.ProjectWithWorkHours;
			foreach (var project in projectRepository.Projects)
			{
				foreach (var employeeWithWorkHours in project.EmployeeWithWorkHours.ToList())
				{
					if (employeeWithWorkHours.Employee.Oib == employeeToEdit.Oib)
					{
						var willBeAddedInTheFuture = false;
						foreach (var projectItem in projectWithWorkHours)
						{
							if (projectItem.Project.Name == project.Name) willBeAddedInTheFuture = true;
						}

						if (project.EmployeeWithWorkHours.Count == 1 && !willBeAddedInTheFuture)
						{
							return "There must be at least one employee in project.";
						}

						project.EmployeeWithWorkHours.Remove(employeeWithWorkHours);
					}
				}
			}

			employeeToEdit.ProjectWithWorkHours = projectWithWorkHours;
			foreach (var projectWithWorkHoursItem in projectsToAdd)
			{
				var employee1 = new EmployeeWithWorkHours();
				employee1.Employee = employeeToEdit;
				employee1.WorkHours = projectWithWorkHoursItem.WorkHours;
				projectWithWorkHoursItem.Project.EmployeeWithWorkHours.Add(employee1);
			}

			return null;
		}
	}
}
