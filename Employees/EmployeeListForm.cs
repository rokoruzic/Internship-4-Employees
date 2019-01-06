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
		public EmployeeRepository EmployeeRepository;
		public EmployeeListForm()
		{
			InitializeComponent();
			EmployeeRepository= new EmployeeRepository();
			foreach (var employee in EmployeeRepository.Employees)
			{
				employeesListBox.Items.Add(employee);

			}
			
		}

		private void EditEmployeeClick(object sender, EventArgs e)
		{

			var selectedEmployee = employeesListBox.SelectedItem as Employee;
			if (selectedEmployee == null) return;
			var employeeEditForm = new EmployeeEditForm {SelectedItem = selectedEmployee};
			employeeEditForm.EditedEmployeeSetText();
			employeeEditForm.ShowDialog();
			AddRefreshList();
		}

		private void AddRefreshList()
		{
			employeesListBox.Items.Clear();
			foreach (var employee in EmployeeRepository.Employees)
			{
				employeesListBox.Items.Add(employee);
			}
		}

		private void EmployeeDeleteClick(object sender, EventArgs e)
		{
			var selectedEmployee = employeesListBox.SelectedItem as Employee;
			if (selectedEmployee == null) return;
			EmployeeRepository.Employees.Remove(selectedEmployee);
			AddRefreshList();

		}

		private void EmployeeAddNewClick(object sender, EventArgs e)
		{
			var employeeAddNewForm = new EmployeeAddNewForm(EmployeeRepository);
			employeeAddNewForm.ShowDialog();
			AddRefreshList();




		}
	}
}
