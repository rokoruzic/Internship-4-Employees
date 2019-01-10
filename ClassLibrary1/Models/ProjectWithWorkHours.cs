using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
	public class ProjectWithWorkHours
	{
		public Project Project{ get; set; }
		public int WorkHours { get; set; }

		public override string ToString()
		{
			return $"{Project.ToString()} Work hours: {WorkHours}";
		}

		public  string ProjectName()
		{
			return $"{Project.Name} {WorkHours}";
		}
		
	}
}
