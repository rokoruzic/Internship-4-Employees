using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary1.Models;

namespace Employees.Domain.Repositories
{
	public class ProjectRepository
	{
		public List<Project> Projects;

		public ProjectRepository()
		{
			Projects = new List<Project>()
			{
				new Project("project space oddity", new DateTime(2017, 12, 20), new DateTime(2018, 10, 10)),
			};
		}

		public bool IsProjectValid(Project project)
		{
			foreach (var project1 in Projects)
			{
				if (project.Name == project1.Name) return false;
			}

			return true;
		}

		public string Add(Project projectToAdd, EmployeeRepository employeeRepository,
			List<EmployeeWithWorkHours> employeeWithWorkHours)
		{
			if (!projectToAdd.IsEndDateAfterStartDate())
				return "Project End date is not valid, it must be after start date. Try again.";

			if (!IsProjectValid(projectToAdd)) return "There is already a project with that name.";

			Projects.Add(projectToAdd);
			projectToAdd.EmployeeWithWorkHours = employeeWithWorkHours;

			foreach (var employee in employeeRepository.Employees)
			{
				foreach (var employeeWithWorkHoursItem in employeeWithWorkHours)
				{
					if (employeeWithWorkHoursItem.Employee.Oib == employee.Oib)
					{
						var projectWithWorkHours = new ProjectWithWorkHours();
						projectWithWorkHours.Project = projectToAdd;
						projectWithWorkHours.WorkHours = employeeWithWorkHoursItem.WorkHours;
						employee.ProjectWithWorkHours.Add(projectWithWorkHours);
					}
				}
			}
			return null;
		}

		public string Edit(Project projectToEdit, EmployeeRepository employeeRepository,
			List<EmployeeWithWorkHours> employeeWithWorkHours)
		{
			projectToEdit.EmployeeWithWorkHours = employeeWithWorkHours;
			if (projectToEdit.EmployeeWithWorkHours.Count == 0)
				return "There must be at least one employee in project.";
			if (!projectToEdit.IsEndDateAfterStartDate())
				return "Project End date is not valid, it must be after start date. Try again.";
			var employeesToAdd = projectToEdit.EmployeeWithWorkHours;
			foreach (var employee in employeeRepository.Employees)
			{
				foreach (var projectWithWorkHours in employee.ProjectWithWorkHours.ToList())
				{
					if (projectWithWorkHours.Project.Name == projectToEdit.Name)
						employee.ProjectWithWorkHours.Remove(projectWithWorkHours);
				}
			}

			foreach (var employeeWithWorkHoursItem in employeesToAdd)
			{
				var project1 = new ProjectWithWorkHours();
				project1.Project = projectToEdit;
				project1.WorkHours = employeeWithWorkHoursItem.WorkHours;
				employeeWithWorkHoursItem.Employee.ProjectWithWorkHours.Add(project1);
			}

			return null;
		}

		public string Delete(Project projectToDelete, EmployeeRepository employeeRepository)
		{
			Projects.Remove(projectToDelete);

			foreach (var employee in employeeRepository.Employees)
			{
				var listForForeach = employee.ProjectWithWorkHours.ToList();
				foreach (var project in listForForeach)
				{
					employee.ProjectWithWorkHours.Remove(project);
				}
			}
			return null;
		}
	}
}
