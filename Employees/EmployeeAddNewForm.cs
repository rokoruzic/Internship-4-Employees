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

			if (firstNameAddNewTextbox.Text == null || lastNameAddNewTextbox.Text == null || oibAddNewTextbox.Text == null)
			{
				var EmptyAddEmployeeErrorForm = new EmptyAddEmployeeErrorForm();
				EmptyAddEmployeeErrorForm.ShowDialog();
				ErrorDialog.ShowDialog();
			}

		}

		

		private void EmployeeAddNewSaveClick(object sender, EventArgs e)
		{
			if (firstNameAddNewTextbox.Text == null || lastNameAddNewTextbox.Text == null || oibAddNewTextbox.Text == null
			  ||  workPositionAddNewComboBox.SelectedItem==null)
			{
				var emptyAddEmployeeErrorForm = new EmptyAddEmployeeErrorForm();
				emptyAddEmployeeErrorForm.ShowDialog();
			}
			else
			{
				var Employee = new Employee(firstNameAddNewTextbox.Text, lastNameAddNewTextbox.Text,
					oibAddNewTextbox.Text, (WorkPosition) workPositionAddNewComboBox.SelectedItem,
					dateOfBirthAddNewDateTimePicker.Value);
				if (employeeRepository1.CreateEmployee(Employee))
				{
					employeeRepository1.Employees.Add(Employee);
				}
			}
			Close();







		}
	}
}
