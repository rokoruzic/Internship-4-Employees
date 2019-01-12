using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Employees.Infrastructure.Extensions;

namespace ClassLibrary1.Models
{
	public class Project
	{
		private string _name { get; set; }

		public string Name
		{
			get { return _name; }
			set { _name = value.FirstCharToUpperAndRemoveMultipleWhiteSpaces(); }
		}

		public List<EmployeeWithWorkHours> EmployeeWithWorkHours { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public Project(string name,
			DateTime startDate, DateTime endDate)
		{
			Name = name;
			StartDate = startDate;
			EndDate = endDate;
			EmployeeWithWorkHours = new List<EmployeeWithWorkHours>();
		}

		public override string ToString()
		{
			return $"{Name}";
		}

		public bool IsEndDateAfterStartDate()
		{
			return EndDate > StartDate;
		}
	}
}
