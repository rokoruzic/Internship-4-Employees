using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClassLibrary1.Enums;
using Employees.Infrastructure.Extensions;

namespace ClassLibrary1.Models
{
	public class Employee
	{
		public List<ProjectWithWorkHours> ProjectWithWorkHours { get; set; }
		private string _firstName;

		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value.CapitalizeFirstLetterAndRemoveMultipleWhiteSpaces(); }
		}

		private string _lastName { get; set; }

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value.CapitalizeFirstLetterAndRemoveMultipleWhiteSpaces(); }
		}

		private string _oib { get; set; }

		public string Oib
		{
			get { return _oib; }
			set { _oib = value.RemoveAllWhiteSpaces(); }
		}

		public DateTime DateOfBirth { get; set; }
		public WorkPosition WorkPosition { get; set; }

		public Employee(string firstName, string lastName, string oib, WorkPosition workPosition, DateTime dateOfBirth)
		{
			FirstName = firstName;
			LastName = lastName;
			Oib = oib;
			WorkPosition = workPosition;
			DateOfBirth = dateOfBirth;
			ProjectWithWorkHours = new List<ProjectWithWorkHours>();
		}

		public override string ToString()
		{
			return $"{FirstName} {LastName} ";
		}

		public string PrintFullName()
		{
			return $"{FirstName} {LastName} {WorkHoursCount()} ";
		}

		public int WorkHoursCount()
		{
			var workHoursCount = 0;
			foreach (var workHours in ProjectWithWorkHours)
			{
				workHoursCount += workHours.WorkHours;
			}

			return workHoursCount;
		}

		public int NumberOfPlannedProjects()
		{
			int counter = 0;
			foreach (var startEndDateTime in ProjectWithWorkHours)
			{
				if (startEndDateTime.Project.StartDate > DateTime.Now) counter++;
			}

			return counter;
		}

		public int NumberOfCurrentProjects()
		{
			int counter = 0;
			foreach (var startEndDateTime in ProjectWithWorkHours)
			{
				if (startEndDateTime.Project.StartDate < DateTime.Now &&
				    startEndDateTime.Project.EndDate > DateTime.Now)
					counter++;
			}

			return counter;
		}

		public int NumberOfPreviousProjects()
		{
			int counter = 0;
			foreach (var startEndDateTime in ProjectWithWorkHours)
			{
				if (startEndDateTime.Project.EndDate < DateTime.Now) counter++;
			}

			return counter;
		}

		public bool IsOibValid()
		{
			return Regex.IsMatch(Oib, @"^[a-zA-Z]+$") && Oib.Length == 11;
		}
	}
}
