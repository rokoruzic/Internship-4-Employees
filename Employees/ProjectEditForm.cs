﻿using System;
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
	public partial class ProjectEditForm : Form
	{
		public Project SelectedProject { get; set; }
		public EmployeeRepository EmployeeRepository { get; set; }
		public ProjectEditForm(EmployeeRepository employeeRepository)
		{
			InitializeComponent();
			EmployeeRepository = employeeRepository;
		}

		public void SetText()
		{
			projectNameTextBox.Text = SelectedProject.Name;
			projectStartDateDatePicker.Value = SelectedProject.StartDate;
			projectEndDateDatePicker.Value = SelectedProject.EndDate;

		}

		public void RefreshList()
		{

			bool isFound;
			foreach (var employee in EmployeeRepository.Employees)
			{
				isFound = false;
				foreach (var employeeWithWorkHours in SelectedProject.EmployeeWithWorkHours)

				{
					if (employeeWithWorkHours.Employee.Oib == employee.Oib)
						isFound = true;
				}

				if (!isFound)
					addEmployeeToProjectComboBox.Items.Add(employee);
			}

			foreach (var selectedProjectEmployeeWithWorkHour in SelectedProject.EmployeeWithWorkHours)
			{
				removeEmployeeFromProjectComboBox.Items.Add(selectedProjectEmployeeWithWorkHour);
			}
		}

		private void ProjectEditSaveClick(object sender, EventArgs e)
		{

			SelectedProject.Name = projectNameTextBox.Text;
			SelectedProject.StartDate = projectStartDateDatePicker.Value;
			SelectedProject.EndDate = projectEndDateDatePicker.Value;
			if (!SelectedProject.IsEndDateAfterStartDate())
				return;
			SelectedProject.EmployeeWithWorkHours = new List<EmployeeWithWorkHours>();

			foreach (var employeeWithWorkHours in removeEmployeeFromProjectComboBox.Items)
			{
				SelectedProject.EmployeeWithWorkHours.Add(employeeWithWorkHours as EmployeeWithWorkHours);
			}

			var employeesToAdd = SelectedProject.EmployeeWithWorkHours;
			foreach (var employee in EmployeeRepository.Employees)
			{
				var listForForeach = employee.ProjectWithWorkHours.ToList();
				foreach (var projectWithWorkHours in listForForeach)
				{
					if (projectWithWorkHours.Project.Name == SelectedProject.Name)
						employee.ProjectWithWorkHours.Remove(projectWithWorkHours);
				}

			}

			if (SelectedProject.IsEmployeeInProject())
			{
				foreach (var employeeWithWorkHours in employeesToAdd)
				{
					var project1 = new ProjectWithWorkHours();
					project1.Project = SelectedProject;
					project1.WorkHours = employeeWithWorkHours.WorkHours;
					employeeWithWorkHours.Employee.ProjectWithWorkHours.Add(project1);
				}
			}
			else return;

			Close();


		}

		private void RemoveEmployeeFromProjectClick(object sender, EventArgs e)
		{
			var tempEmployee = removeEmployeeFromProjectComboBox.SelectedItem;
			var tempEmployee2 = tempEmployee as EmployeeWithWorkHours;
			removeEmployeeFromProjectComboBox.Items.Remove(tempEmployee);
			addEmployeeToProjectComboBox.Items.Add(tempEmployee2.Employee);
			removeEmployeeFromProjectComboBox.ResetText();
			addEmployeeToProjectComboBox.ResetText();
		}

		private void AddEmployeeToProjectClick(object sender, EventArgs e)
		{
			var employeeWithWorkHours = new EmployeeWithWorkHours();
			employeeWithWorkHours.WorkHours = (int)employeeAddWorkHoursNumUpDown.Value;
			employeeWithWorkHours.Employee = (Employee)addEmployeeToProjectComboBox.SelectedItem;
			removeEmployeeFromProjectComboBox.Items.Add(employeeWithWorkHours);
			addEmployeeToProjectComboBox.ResetText();
		}
	}
}