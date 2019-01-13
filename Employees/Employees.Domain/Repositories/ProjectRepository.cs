using System;
using System.Collections.Generic;
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
