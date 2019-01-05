using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1.Models;
using Employees.Domain.Repositories;

namespace Employees
{
	public partial class EmployeeListForm : Form
	{
		public EmployeeRepository _employeeRepository;
		public EmployeeListForm()
		{
			InitializeComponent();
			_employeeRepository= new EmployeeRepository();
			foreach (var employee in _employeeRepository.Employees)
			{
				employeesListBox.Items.Add(employee);

			}
			
		}

		private void EditEmployeeClick(object sender, EventArgs e)
		{
			var selectedEmployee = employeesListBox.SelectedItem as Employee;
			var _EmployeeEditForm = new EmployeeEditForm();
			_EmployeeEditForm.SelectedItem = selectedEmployee;
			_EmployeeEditForm.EditedEmployeeSetText();
			_EmployeeEditForm.ShowDialog();

			var a = 5;
		}
	}
}
