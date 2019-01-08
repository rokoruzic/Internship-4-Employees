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
		public ProjectWithWorkHours ProjectWithWorkHours { get; set; }
		public EmployeeEditForm()
		{
			InitializeComponent();
			ProjectRepository=new ProjectRepository();
			ProjectWithWorkHours=new ProjectWithWorkHours();
			foreach (var workPosition in (WorkPosition[])Enum.GetValues(typeof(WorkPosition)))
			{
				employeeEditWorkPositionComboBox.Items.Add(workPosition);
			}

			foreach (var VARIABLE in ProjectRepository.Project)
			{
				addProjectToEmployeeComboBox.Items.Add(VARIABLE);

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

		private void EmployeeEditSaveButton(object sender, EventArgs e)
		{
			SelectedItem.FirstName = employeeEditFirstNameTextBox.Text;
			SelectedItem.LastName = employeeLastNameEditTextBox.Text;
			SelectedItem.DateOfBirth = employeeEditDateTimePicker.Value;
			SelectedItem.WorkPosition = (WorkPosition) employeeEditWorkPositionComboBox.SelectedItem;
			SelectedItem.ProjectWithWorkHours.Add(ProjectWithWorkHours);

			Close();

		}

		private void AddProjectToEmployeeClick(object sender, EventArgs e)
		{
			int text = Int32.Parse(workHoursTextBox.Text);
			ProjectWithWorkHours.WorkHours = text;
			ProjectWithWorkHours.Project = (Project) addProjectToEmployeeComboBox.SelectedItem;

			RemoveProjectFromEmployeeComboBox.Items.Add(ProjectWithWorkHours);
			foreach (var project in ProjectRepository.Project)
			{
				if ( ProjectWithWorkHours.Project.Name ==project.Name)
					addProjectToEmployeeComboBox.Items.Remove(project);


			}


		}
		
	}
}
