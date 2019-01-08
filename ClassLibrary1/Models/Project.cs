using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
	public class Project {
		public string Name {get; set;}
		//public Tuple<List<Employee>, List<int>> EmployeesWorkHoursTuple{ get; set; }
		public DateTime StartDate { get; set;}
		public DateTime EndDate { get; set; }
		public Project(string name, List<Employee> employees,
			DateTime startDate, DateTime endDate, List<int> workHours)
		{
			Name = name;
			StartDate = startDate;
			EndDate = endDate;
		}

		public override string ToString()
		{
			return $"{Name}";
		}

		
	}
}
