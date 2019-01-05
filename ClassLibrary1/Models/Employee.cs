using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Enums;
using Employees.Infrastructure.Extensions;

namespace ClassLibrary1.Models
{
	public class Employee
	{
		private string _firstName { get; set; }
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

		public Employee(string firstName, string lastName, string oib, WorkPosition workPosition
		,DateTime dateOfBirth)
		{
			FirstName = firstName;
			LastName = lastName;
			Oib = oib;
			WorkPosition = workPosition;
			DateOfBirth = dateOfBirth;

		}

		public override string ToString()
		{
			return $"{FirstName} {LastName} {Oib} {DateOfBirth} {WorkPosition}";
		}
	}
}
