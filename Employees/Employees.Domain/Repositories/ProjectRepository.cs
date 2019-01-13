using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		public bool CreateProject(Project project)
		{
			foreach (var project1 in Projects)
			{
				if (project.Name == project1.Name) return false;
			}

			return true;
		}

		public string AddEmployeeWithWorkHours(Employee employeeToEdit, List<ProjectWithWorkHours> projectWithWorkhours)
		{
			foreach (var project in Projects)
			{
				foreach (var employeeWithWorkHours in project.EmployeeWithWorkHours.ToList())
				{
					if (employeeWithWorkHours.Employee.Oib == employeeToEdit.Oib)
					{
						foreach (var employeeWithProjectWithWorkHours in employeeToEdit.ProjectWithWorkHours)
						{
							foreach (var projectWithWorkHoursItem in projectWithWorkhours)
							{
								if (employeeWithProjectWithWorkHours.Project.Name ==
									project.Name && projectWithWorkHoursItem.Project.Name != project.Name
												 && project.EmployeeWithWorkHours.Count == 1)
									return "There must be at least one employee in project.";
								project.EmployeeWithWorkHours.Remove(employeeWithWorkHours);


							}
						}

					}

				}
			}

			var projectsToAdd = projectWithWorkhours;
					foreach (var projectWithWorkHours in projectsToAdd)
					{
						var employeeWithWorkHours1 = new EmployeeWithWorkHours
						{
							Employee = employeeToEdit,
							WorkHours = projectWithWorkHours.WorkHours
						};
						projectWithWorkHours.Project.EmployeeWithWorkHours.Add(employeeWithWorkHours1);
					}
				

				return null;
			


		}
	}
}

	

