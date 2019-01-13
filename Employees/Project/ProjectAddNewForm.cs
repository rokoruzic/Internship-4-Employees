using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibrary1.Models;
using Employees.Domain.Repositories;
using Employees.Errors;

namespace Employees
{
	public partial class ProjectAddNewForm : Form
	{
		public ProjectRepository ProjectRepository { get; set; }
		public EmployeeRepository EmployeeRepository { get; set; }
		public List<EmployeeWithWorkHours> EmployeeWithWorkHoursList { get; set; }
		public List<ProjectWithWorkHours> ProjectWithWorkHoursList { get; set; }
		public Project Project { get; set; }

		public ProjectAddNewForm(ProjectRepository projectRepository, EmployeeRepository employeeRepository)
		{
			InitializeComponent();
			ProjectRepository = projectRepository;
			EmployeeRepository = employeeRepository;
			EmployeeWithWorkHoursList = new List<EmployeeWithWorkHours>();
			ProjectWithWorkHoursList = new List<ProjectWithWorkHours>();
			Project = new Project("a", DateTime.Now, DateTime.Now.AddDays(1));
			employeeAddToProjectButton.Hide();

		}

		public void AddRefreshList()
		{
			bool isFound;
			foreach (var employee in EmployeeRepository.Employees)
			{
				isFound = false;
				foreach (var employeeWithWorkHours in Project.EmployeeWithWorkHours)
				{
					if (employee.Oib == employeeWithWorkHours.Employee.Oib)
						isFound = true;
				}

				if (!isFound)
					projectSelectEmployeesComboBox.Items.Add(employee);
			}
		}

		private void EmployeeAddToProjectClick(object sender, EventArgs e)
		{
			if (addWorkHoursToEmployeeNumUpDown.Value == 0)
			{
				var errorForm = new ErrorForm("Work hours can't be zero.");
				errorForm.ShowDialog();
				return;
			}

			if (projectSelectEmployeesComboBox.SelectedItem == null)
			{
				var errorForm = new ErrorForm("You need to select item before clicking add.");
				errorForm.ShowDialog();
				return;
			}

			var employeeWithWorkHours = new EmployeeWithWorkHours();
			var employeeToRemove = projectSelectEmployeesComboBox.SelectedItem;
			employeeWithWorkHours.Employee = projectSelectEmployeesComboBox.SelectedItem as Employee;
			employeeWithWorkHours.WorkHours = (int) addWorkHoursToEmployeeNumUpDown.Value;
			EmployeeWithWorkHoursList.Add(employeeWithWorkHours);
			projectSelectEmployeesComboBox.Items.Remove(employeeToRemove);
			projectSelectEmployeesComboBox.ResetText();
			addWorkHoursToEmployeeNumUpDown.ResetText();
			employeeAddToProjectButton.Hide();
		}

		private void ProjectAddNewSaveClick(object sender, EventArgs e)
		{
			if (projectSelectEmployeesComboBox.Items.Count == EmployeeRepository.Employees.Count)
			{
				var errorForm = new ErrorForm("There must be at least one employee in project.");
				errorForm.ShowDialog();
				return;
			}

			Project.Name = newProjectNameTextBox.Text;
			Project.StartDate = newProjectStartDateDatePicker.Value;
			Project.EndDate = newProjectEndDateDatePicker.Value;
			if (string.IsNullOrEmpty(Project.Name))
			{
				var errorForm = new ErrorForm("Please fill all boxes.");
				errorForm.ShowDialog();
				return;
			}

			var result = ProjectRepository.Add(Project, EmployeeRepository, EmployeeWithWorkHoursList);
			if (result != null)
			{
				var errorForm = new ErrorForm(result);
				errorForm.ShowDialog();
				return;
			}


			Close();
		}

		private void ProjectSelectEmployeesSelectItem(object sender, EventArgs e)
		{
			employeeAddToProjectButton.Show();
		}

		
	}
}
