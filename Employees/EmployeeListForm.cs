﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ClassLibrary1.Models;
using Employees.Domain.Repositories;
using Employees.Errors;

namespace Employees
{
	public partial class EmployeeListForm : Form
	{
		public EmployeeRepository EmployeeRepository;
		public ProjectRepository ProjectRepository;
		
		public EmployeeListForm(EmployeeRepository employeeRepository ,ProjectRepository projectRepository)
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
			var employeeEditForm = new EmployeeEditForm(ProjectRepository) {SelectedItem = selectedEmployee};

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

			if (!ProjectRepository.IsTwoEmployees())
			{
				var errorForm = new ErrorForm("You can't delete this employee because project has only this selected employee");
				errorForm.ShowDialog();
				return;
			}

			EmployeeRepository.Employees.Remove(selectedEmployee);
			ProjectRepository.Employees.Remove(selectedEmployee);
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
			var employeeDetailsForm = new EmployeeDetailsForm{SelectedItem = selectedEmployee};
			employeeDetailsForm.SetText();
			employeeDetailsForm.ShowDialog();




		}
	}
}
