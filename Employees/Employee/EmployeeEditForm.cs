using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibrary1.Enums;
using ClassLibrary1.Models;
using Employees.Domain.Repositories;
using Employees.Errors;

namespace Employees
{
	public partial class EmployeeEditForm : Form
	{
		public Employee SelectedItem { get; set; }
		public ProjectRepository ProjectRepository { get; set; }
		public EmployeeRepository EmployeeRepository { get; set; }

		public EmployeeEditForm(ProjectRepository projectRepository, EmployeeRepository employeeRepository)
		{
			InitializeComponent();
			ProjectRepository = projectRepository;
			EmployeeRepository = employeeRepository;

			foreach (var workPosition in (WorkPosition[]) Enum.GetValues(typeof(WorkPosition)))
			{
				employeeEditWorkPositionComboBox.Items.Add(workPosition);
			}

			employeeEditDateTimePicker.MaxDate = DateTime.Now.AddYears(-18);
				addProjectToNewEmployeeButton.Hide();
		}

		public void EditedEmployeeSetText()
		{
			employeeEditFirstNameTextBox.Text = SelectedItem.FirstName;
			employeeLastNameEditTextBox.Text = SelectedItem.LastName;
			employeeEditDateTimePicker.Value = SelectedItem.DateOfBirth;
			employeeEditWorkPositionComboBox.SelectedItem = SelectedItem.WorkPosition;
		}

		public void RefreshList()
		{
			bool isFound;
			foreach (var project in ProjectRepository.Projects)
			{
				isFound = false;
				foreach (var projectWithWorkHours in SelectedItem.ProjectWithWorkHours)
				{
					if (projectWithWorkHours.Project.Name == project.Name)
						isFound = true;
				}

				if (!isFound)
					addProjectToEmployeeComboBox.Items.Add(project);
			}

			foreach (var projectWithWorkHours in SelectedItem.ProjectWithWorkHours)
			{
				RemoveProjectFromEmployeeComboBox.Items.Add(projectWithWorkHours);
			}
		}

		private void EmployeeEditSaveButton(object sender, EventArgs e)
		{
			SelectedItem.FirstName = employeeEditFirstNameTextBox.Text;
			SelectedItem.LastName = employeeLastNameEditTextBox.Text;
			SelectedItem.DateOfBirth = employeeEditDateTimePicker.Value;
			if (string.IsNullOrEmpty(SelectedItem.FirstName) || string.IsNullOrEmpty(SelectedItem.LastName)
			                                                 || string.IsNullOrEmpty(SelectedItem.Oib)
			)
			{
				var errorForm = new ErrorForm("Please fill all boxes.");
				errorForm.ShowDialog();
				return;
			}

			SelectedItem.WorkPosition = (WorkPosition) employeeEditWorkPositionComboBox.SelectedItem;

			var removeComboBoxProjects = new List<ProjectWithWorkHours>();
			foreach (var projectWithWorkHoursItem in RemoveProjectFromEmployeeComboBox.Items)
			{
				removeComboBoxProjects.Add(projectWithWorkHoursItem as ProjectWithWorkHours);
			}

			var result = EmployeeRepository.Edit(SelectedItem, ProjectRepository, removeComboBoxProjects);
			if (result != null)
			{
				var errorForm = new ErrorForm(result);
				errorForm.ShowDialog();
				return;
			}

			Close();
		}

		private void AddProjectToEmployeeClick(object sender, EventArgs e)
		{
			if (workHoursNumericUpDown.Value == 0)
			{
				var errorForm = new ErrorForm("Work hours can't be zero.");
				errorForm.ShowDialog();
				return;
			}

			if (addProjectToEmployeeComboBox.SelectedItem == null)
			{
				var errorForm = new ErrorForm("You need to select item before clicking add.");
				errorForm.ShowDialog();
				return;
			}


			var projectWithWorkHours = new ProjectWithWorkHours();
			projectWithWorkHours.WorkHours = (int) workHoursNumericUpDown.Value;
			projectWithWorkHours.Project = (Project) addProjectToEmployeeComboBox.SelectedItem;


			RemoveProjectFromEmployeeComboBox.Items.Add(projectWithWorkHours);
			foreach (var project in ProjectRepository.Projects)
			{
				if (projectWithWorkHours.Project.Name == project.Name)
					addProjectToEmployeeComboBox.Items.Remove(project);
			}

			addProjectToEmployeeComboBox.ResetText();
			addProjectToNewEmployeeButton.Hide();
		}

		private void EmployeeDeleteProjectClick(object sender, EventArgs e)
		{
			if (RemoveProjectFromEmployeeComboBox.SelectedItem == null)
			{
				var errorForm = new ErrorForm("You must select project to delete");
				errorForm.ShowDialog();
				return;
			}

			var tempProject = RemoveProjectFromEmployeeComboBox.SelectedItem;
			var tempProject2 = tempProject as ProjectWithWorkHours;
			RemoveProjectFromEmployeeComboBox.Items.Remove(tempProject);
			addProjectToEmployeeComboBox.Items.Add(tempProject2.Project);
			RemoveProjectFromEmployeeComboBox.ResetText();
			addProjectToEmployeeComboBox.ResetText();
		}

		private void addProjectToEmployeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			addProjectToNewEmployeeButton.Show();
		}
	}
}
