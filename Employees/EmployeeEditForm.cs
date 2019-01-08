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
	public partial class EmployeeEditForm : Form
	{
		public Employee SelectedItem { get; set; }
		public ProjectRepository ProjectRepository { get; set; }
		public EmployeeEditForm()
		{
			InitializeComponent();
			ProjectRepository=new ProjectRepository();
			foreach (var workPosition in (WorkPosition[])Enum.GetValues(typeof(WorkPosition)))
			{
				employeeEditWorkPositionComboBox.Items.Add(workPosition);
			}

			




			employeeEditDateTimePicker.MaxDate = DateTime.Now.AddYears(-18);

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
					if (projectWithWorkHours.ProjectName() == project.Name)
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
			SelectedItem.WorkPosition = (WorkPosition) employeeEditWorkPositionComboBox.SelectedItem;
			SelectedItem.ProjectWithWorkHours=new List<ProjectWithWorkHours>();
			foreach (var projectWithWorkHoursItem in RemoveProjectFromEmployeeComboBox.Items)
			{
				SelectedItem.ProjectWithWorkHours.Add(projectWithWorkHoursItem as ProjectWithWorkHours);
			}
			Close();
		}

		private void AddProjectToEmployeeClick(object sender, EventArgs e)
		{

			
			var projectWithWorkHours = new ProjectWithWorkHours();
			projectWithWorkHours.WorkHours = workHoursNumericUpDown.DecimalPlaces;
			projectWithWorkHours.Project= (Project)addProjectToEmployeeComboBox.SelectedItem;


			RemoveProjectFromEmployeeComboBox.Items.Add(projectWithWorkHours);
			foreach (var project in ProjectRepository.Projects)
			{
				if (projectWithWorkHours.Project.Name ==project.Name)
					addProjectToEmployeeComboBox.Items.Remove(project);
			}
		}
		
	}
}
