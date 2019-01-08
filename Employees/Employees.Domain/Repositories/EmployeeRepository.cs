using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Enums;
using ClassLibrary1.Models;

namespace Employees.Domain.Repositories
{
	public class EmployeeRepository
	{
		public List<Employee> Employees;
		

		public EmployeeRepository()
		{
			Employees = new List<Employee>()
			{
				new Employee("Jure","Radalj","123456",WorkPosition.Developer,new DateTime(1993,12,23)),
				new Employee("Petra c","Peslac","987654",WorkPosition.Secretary,new DateTime(1994,12,20)),
				new Employee("kristian", "zolo","122122",WorkPosition.Manager,new DateTime(1994,3,20)),
				new Employee("Skylar", "White","984123",WorkPosition.Accountant,new DateTime(1968,10,11)),
				new Employee("Duje","mihanovic","109983",WorkPosition.WebDeveloper,new DateTime(1985,1,9))
			};
		}

		public bool CreateEmployee(Employee employeeToAdd)
		{
			foreach (var employee in Employees)
			{
				if (employee.Oib == employeeToAdd.Oib || employeeToAdd.DateOfBirth.AddYears(18) > DateTime.Now)
					return false;
			}
			
			return true;
		}

	}
}
