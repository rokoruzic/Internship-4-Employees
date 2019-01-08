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
		public List<Project> Project;
		public List<int> WorkHours;

		public ProjectRepository()
		{
			WorkHours=new List<int>();
			WorkHours.Add(20);
			WorkHours.Add(30);
			WorkHours.Add(15);
			WorkHours.Add(52);
			WorkHours.Add(40);
			Project = new List<Project>()
			{
				new Project("Project Horde", Employees, new DateTime(2017, 12, 20),
					new DateTime(2018, 10, 10),WorkHours),
				new Project("Project Alliance", Employees, new DateTime(2017, 12, 20),
				new DateTime(2018, 10, 10),WorkHours)
			};
		}
	}
}
