﻿using System;
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
		private List<Employee> _employees;

		public EmployeeRepository()
		{
			_employees = new List<Employee>()
			{
				new Employee("Jure","Radalj","123456",WorkPosition.Developer,new DateTime(1993,12,23)),
				new Employee("Petra c","Peslac","987654",WorkPosition.Secretary,new DateTime(1994,12,20)),
				new Employee("kristian", "zolo","122122",WorkPosition.Manager,new DateTime(1994,3,20)),
				new Employee("Skylar", "White","984123",WorkPosition.Accountant,new DateTime(1968,10,11)),
				new Employee("Jesse","pinkman","109983",WorkPosition.WebDeveloper,new DateTime(1985,1,9))
			};
		}
	}
}
