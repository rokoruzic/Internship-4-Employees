using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibrary1.Models;
using Employees.Domain.Repositories;
using Employees.Errors;

namespace Employees
{
	public partial class ProjectEditForm : Form
	{
		public Project SelectedProject { get; set; }
		public EmployeeRepository EmployeeRepository { get; set; }
		public ProjectRepository ProjectRepository { get; set; }

		public ProjectEditForm(EmployeeRepository employeeRepository, ProjectRepository projectRepository)
		{
			InitializeComponent();
			EmployeeRepository = employeeRepository;
			ProjectRepository = projectRepository;
			if (addEmployeeToProjectComboBox.SelectedItem == null) addEmployeeToProjectButton.Hide();
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
					if (employeeWithWorkHours.Employee.Oib == employee.Oib) isFound = true;
				}

				if (!isFound) addEmployeeToProjectComboBox.Items.Add(employee);
			}

			foreach (var selectedProjectEmployeeWithWorkHour in SelectedProject.EmployeeWithWorkHours)
			{
				removeEmployeeFromProjectComboBox.Items.Add(selectedProjectEmployeeWithWorkHour);
			}
		}

		private void ProjectEditSaveClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(projectNameTextBox.Text))
			{
				var errorForm = new ErrorForm("Please fill all boxes.");
				errorForm.ShowDialog();
				return;
			}

			var tempProject = new Project(projectNameTextBox.Text, projectStartDateDatePicker.Value,
				projectEndDateDatePicker.Value);

			foreach (var project in ProjectRepository.Projects)
			{
				if (tempProject.Name == project.Name && projectNameTextBox.Text != project.Name)
				{
					var errorForm = new ErrorForm("There is already a project with that name.");
					errorForm.ShowDialog();
					return;
				}
			}

			SelectedProject.Name = projectNameTextBox.Text;
			SelectedProject.StartDate = projectStartDateDatePicker.Value;
			SelectedProject.EndDate = projectEndDateDatePicker.Value;
			var removeEmployeeFromProjectComboBoxItems = new List<EmployeeWithWorkHours>();
			foreach (var employeeWithWorkHoursItem in removeEmployeeFromProjectComboBox.Items)
			{
				removeEmployeeFromProjectComboBoxItems.Add(employeeWithWorkHoursItem as EmployeeWithWorkHours);
			}

			var result = ProjectRepository.Edit(SelectedProject, EmployeeRepository,
				removeEmployeeFromProjectComboBoxItems);
			if (result != null)
			{
				var errorForm = new ErrorForm(result);
				errorForm.ShowDialog();
				return;
			}

			Close();
		}

		private void RemoveEmployeeFromProjectClick(object sender, EventArgs e)
		{
			var tempEmployee = removeEmployeeFromProjectComboBox.SelectedItem;
			if (removeEmployeeFromProjectComboBox.SelectedItem == null)
			{
				var errorForm = new ErrorForm("You must select employee to delete");
				errorForm.ShowDialog();
				return;
			}

			var tempEmployee2 = tempEmployee as EmployeeWithWorkHours;
			removeEmployeeFromProjectComboBox.Items.Remove(tempEmployee);
			addEmployeeToProjectComboBox.Items.Add(tempEmployee2.Employee);
			removeEmployeeFromProjectComboBox.ResetText();
			addEmployeeToProjectComboBox.ResetText();
		}

		private void AddEmployeeToProjectClick(object sender, EventArgs e)
		{
			if (addEmployeeToProjectComboBox.SelectedItem == null)
			{
				var errorForm = new ErrorForm("You need to select item before clicking add.");
				errorForm.ShowDialog();
				return;
			}

			if (employeeAddWorkHoursNumUpDown.Value == 0)
			{
				var errorForm = new ErrorForm("Work hours can't be zero.");
				errorForm.ShowDialog();
				return;
			}

			var employeeWithWorkHours = new EmployeeWithWorkHours();
			employeeWithWorkHours.WorkHours = (int) employeeAddWorkHoursNumUpDown.Value;
			employeeWithWorkHours.Employee = (Employee) addEmployeeToProjectComboBox.SelectedItem;

			removeEmployeeFromProjectComboBox.Items.Add(employeeWithWorkHours);
			foreach (var employee in EmployeeRepository.Employees)
			{
				if (employeeWithWorkHours.Employee.Oib == employee.Oib)
					addEmployeeToProjectComboBox.Items.Remove(employee);
			}

			addEmployeeToProjectComboBox.ResetText();
			addEmployeeToProjectButton.Hide();
		}

		private void ShowAddButton(object sender, EventArgs e)
		{
			addEmployeeToProjectButton.Show();
		}
	}
}