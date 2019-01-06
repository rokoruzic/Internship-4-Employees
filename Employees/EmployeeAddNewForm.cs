using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1.Enums;
using ClassLibrary1.Models;
using Employees.Domain.Repositories;

namespace Employees
{
	public partial class EmployeeAddNewForm : Form
	{
		public Employee NewEmployee { get; set; }
		private EmployeeRepository employeeRepository1;
		public EmployeeAddNewForm(EmployeeRepository employeeRepository)
		{
			InitializeComponent();
			employeeRepository1 = employeeRepository;
			foreach (var workPosition in (WorkPosition[])Enum.GetValues(typeof(WorkPosition)))
			{
				workPositionAddNewComboBox.Items.Add(workPosition);
			}
			dateOfBirthAddNewDateTimePicker.MaxDate = DateTime.Now.AddYears(-18);
			
			//if (employeeRepository1.CreateEmployee(NewEmployee))
			//{
			//	employeeRepository1.Employees.Add(NewEmployee);
			//}
		
		}

		

		private void EmployeeAddNewSaveClick(object sender, EventArgs e)
		{
			//firstNameAddNewTextbox.Text = NewEmployee.FirstName;
			//lastNameAddNewTextbox.Text = NewEmployee.LastName;
			//oibAddNewTextbox.Text = NewEmployee.Oib;
			//dateOfBirthAddNewDateTimePicker.Value = NewEmployee.DateOfBirth;
			var Employee = new Employee(firstNameAddNewTextbox.Text,lastNameAddNewTextbox.Text,oibAddNewTextbox.Text,(WorkPosition)workPositionAddNewComboBox.SelectedItem,dateOfBirthAddNewDateTimePicker.Value);
			
			if (employeeRepository1.CreateEmployee(Employee))
			{
				employeeRepository1.Employees.Add(Employee);
			}
			Close();
			


		}
	}
}
