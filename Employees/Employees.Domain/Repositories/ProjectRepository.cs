﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Models;

namespace Employees.Domain.Repositories
{
	public class ProjectRepository:EmployeeRepository
	{
		public List<Project> Projects;

		public ProjectRepository()
		{
			
			Projects = new List<Project>()
			{
				new Project("Project Horde", new DateTime(2017, 12, 20),
					new DateTime(2018, 10, 10)),
				//new Project("Project Alliance", new DateTime(2017, 12, 20),
				//new DateTime(2018, 10, 10))
			};
		}
		public bool CreateProject(Project project)
		{
			foreach (var project1 in Projects)
			{
				if (project.Name==project1.Name)
					return false;
			}

			return true;
		}
	}
}
