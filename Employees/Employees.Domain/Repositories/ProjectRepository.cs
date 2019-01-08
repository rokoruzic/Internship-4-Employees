using System;
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
				new Project("Projects Horde", Employees, new DateTime(2017, 12, 20),
					new DateTime(2018, 10, 10)),
				new Project("Projects Alliance", Employees, new DateTime(2017, 12, 20),
				new DateTime(2018, 10, 10))
			};
		}
	}
}
