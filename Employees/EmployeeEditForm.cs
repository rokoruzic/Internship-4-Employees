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
using Employees.Errors;

namespace Employees
{
	public partial class EmployeeEditForm : Form
	{
		public Employee SelectedItem { get; set; }
		public ProjectRepository ProjectRepository { get; set; }
		public EmployeeEditForm(ProjectRepository projectRepository)
		{
			InitializeComponent();
			ProjectRepository = projectRepository;
			
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
			if (SelectedItem.FirstName == null || SelectedItem.LastName == null || SelectedItem.Oib == null
			    )
			{
				var emptyEditOrNewFillOutBoxesErrorForm = new EmptyEditOrNewFillOutBoxesErrorForm();
				emptyEditOrNewFillOutBoxesErrorForm.ShowDialog();
				return;

			}
		
			SelectedItem.WorkPosition = (WorkPosition) employeeEditWorkPositionComboBox.SelectedItem;
			SelectedItem.ProjectWithWorkHours=new List<ProjectWithWorkHours>();

			foreach (var projectWithWorkHoursItem in RemoveProjectFromEmployeeComboBox.Items)
			{
				SelectedItem.ProjectWithWorkHours.Add(projectWithWorkHoursItem as ProjectWithWorkHours);
			}
			
			var projectsToAdd = SelectedItem.ProjectWithWorkHours;
			foreach (var project in ProjectRepository.Projects)
			{
				var listForForeach = project.EmployeeWithWorkHours.ToList();
				foreach (var employeeWithWorkHours in listForForeach)
				{
					if (employeeWithWorkHours.Employee.Oib == SelectedItem.Oib)
						if (project.EmployeeWithWorkHours.Count <= 1)
						{
							var noEmployeesInProjectErrorForm = new NoEmployeesInProjectErrorForm();
							noEmployeesInProjectErrorForm.ShowDialog();
							return;
						}

					project.EmployeeWithWorkHours.Remove(employeeWithWorkHours);
				}
			}
			

			foreach (var projectWithWorkHours in projectsToAdd)
			{
				var employee1 = new EmployeeWithWorkHours();
				employee1.Employee = SelectedItem;
				employee1.WorkHours = projectWithWorkHours.WorkHours;
				projectWithWorkHours.Project.EmployeeWithWorkHours.Add(employee1);
			}
			
			
			Close();
		}

		private void AddProjectToEmployeeClick(object sender, EventArgs e)
		{
			if (workHoursNumericUpDown.Value == 0)
			{
				var noWorkHoursErrorForm = new NoWorkHoursErrorForm();
				noWorkHoursErrorForm.ShowDialog();
			}
			var projectWithWorkHours = new ProjectWithWorkHours();
			projectWithWorkHours.WorkHours = (int)workHoursNumericUpDown.Value;
			projectWithWorkHours.Project= (Project)addProjectToEmployeeComboBox.SelectedItem;


			RemoveProjectFromEmployeeComboBox.Items.Add(projectWithWorkHours);
			foreach (var project in ProjectRepository.Projects)
			{
				if (projectWithWorkHours.Project.Name == project.Name)
					addProjectToEmployeeComboBox.Items.Remove(project);
			}
			addProjectToEmployeeComboBox.ResetText();
		}

		private void EmployeeDeleteProjectClick(object sender, EventArgs e)
		{
			var tempProject = RemoveProjectFromEmployeeComboBox.SelectedItem;
			var tempProject2 = tempProject as ProjectWithWorkHours;
			RemoveProjectFromEmployeeComboBox.Items.Remove(tempProject);
			addProjectToEmployeeComboBox.Items.Add(tempProject2.Project);
			RemoveProjectFromEmployeeComboBox.ResetText();
			addProjectToEmployeeComboBox.ResetText();

		}
	}
}
