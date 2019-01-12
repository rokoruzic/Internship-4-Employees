using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
	public class Project {
		public string Name {get; set;}
		public List<EmployeeWithWorkHours> EmployeeWithWorkHours { get; set; }
		public DateTime StartDate { get; set;}
		public DateTime EndDate { get; set; }
		public Project(string name,
			DateTime startDate, DateTime endDate)
		{
			Name = name;
			StartDate = startDate;
			EndDate = endDate;
			EmployeeWithWorkHours=new List<EmployeeWithWorkHours>();
		}

		public override string ToString()
		{
			return $"{Name}";
		}

		public bool IsEndDateAfterStartDate()
		{
			return EndDate > StartDate;
		}

		//public  bool IsEmployeeInProject()
		//{
		//	return EmployeeWithWorkHours.Count > 0;
		//}



		
	}
}
