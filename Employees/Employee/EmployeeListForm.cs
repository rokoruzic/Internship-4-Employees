using System;
using System.Windows.Forms;
using ClassLibrary1.Models;
using Employees.Domain.Repositories;
using Employees.Errors;
using Employees.Warnings;

namespace Employees
{
	public partial class EmployeeListForm : Form
	{
		public EmployeeRepository EmployeeRepository { get; set; }
		public ProjectRepository ProjectRepository { get; set; }

		public EmployeeListForm(EmployeeRepository employeeRepository, ProjectRepository projectRepository)
		{
			InitializeComponent();
			EmployeeRepository = employeeRepository;
			ProjectRepository = projectRepository;
			foreach (var employee in EmployeeRepository.Employees)
			{
				employeesListBox.Items.Add(employee);
			}
		}

		private void EditEmployeeClick(object sender, EventArgs e)
		{
			var selectedEmployee = employeesListBox.SelectedItem as Employee;
			if (selectedEmployee == null)
			{
				var errorForm = new ErrorForm("You must select employee to edit");
				errorForm.ShowDialog();
				return;
			}

			var employeeEditForm = new EmployeeEditForm(ProjectRepository, EmployeeRepository)
				{SelectedEmployee = selectedEmployee};

			employeeEditForm.EditedEmployeeSetText();
			employeeEditForm.RefreshList();
			employeeEditForm.ShowDialog();
			AddRefreshList();
		}

		public void AddRefreshList()
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


			if (selectedEmployee == null)
			{
				var errorForm = new ErrorForm("You must select employee to delete");
				errorForm.ShowDialog();
				return;
			}

			var employeeDeleteWarningForm = new EmployeeDeleteWarningForm(EmployeeRepository, ProjectRepository){SelectedEmployee = selectedEmployee};
			employeeDeleteWarningForm.ShowDialog();
			var result = EmployeeRepository.Delete(selectedEmployee, ProjectRepository);
			if (result != null)
			{
				var errorForm = new ErrorForm(result);
				errorForm.ShowDialog();
				return;
			}

			AddRefreshList();
		}

		private void EmployeeAddNewClick(object sender, EventArgs e)
		{
			var employeeAddNewForm = new EmployeeAddNewForm(EmployeeRepository, ProjectRepository);
			employeeAddNewForm.AddRefreshList();
			employeeAddNewForm.ShowDialog();
			AddRefreshList();
		}

		private void ViewDetailsButtonClick(object sender, EventArgs e)
		{
			var selectedEmployee = employeesListBox.SelectedItem as Employee;
			if (selectedEmployee == null)
			{
				var errorForm = new ErrorForm("You must select employee to view");
				errorForm.ShowDialog();
				return;
			}

			var employeeDetailsForm = new EmployeeDetailsForm(ProjectRepository, EmployeeRepository)
				{SelectedItem = selectedEmployee};
			employeeDetailsForm.SetText();
			employeeDetailsForm.ShowDialog();
		}
	}
}
