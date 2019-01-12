using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
	public class EmployeeWithWorkHours
	{
		public Employee Employee { get; set; }
		public int WorkHours { get; set; }

		public override string ToString()
		{
			return $"{Employee.FirstName} {Employee.LastName} Work hours: {WorkHours}";
		}
	}
}
