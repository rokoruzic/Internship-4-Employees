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
	public partial class EmployeeAddNewForm : Form
	{
		public EmployeeRepository EmployeeRepository;
		public ProjectRepository ProjectRepository;
		public List<ProjectWithWorkHours> ProjectWithWorkHoursList;
		public EmployeeAddNewForm(EmployeeRepository employeeRepository, ProjectRepository projectRepository)
		{
			InitializeComponent();
			EmployeeRepository = employeeRepository;
			ProjectRepository = projectRepository;
			ProjectWithWorkHoursList = new List<ProjectWithWorkHours>();
			

			foreach (var workPosition in (WorkPosition[])Enum.GetValues(typeof(WorkPosition)))
			{
				workPositionAddNewComboBox.Items.Add(workPosition);
			}
			dateOfBirthAddNewDateTimePicker.MaxDate = DateTime.Now.AddYears(-18);

			if (firstNameAddNewTextbox.Text == null || lastNameAddNewTextbox.Text == null || oibAddNewTextbox.Text == null)
			{
				var emptyEditOrNewFillOutBoxesErrorForm = new EmptyEditOrNewFillOutBoxesErrorForm();
				emptyEditOrNewFillOutBoxesErrorForm.ShowDialog();
			}

			

		}

		public void AddRefreshList()
		{
			foreach (var project in ProjectRepository.Projects)
			{
				projectAddNewComboBox.Items.Add(project);
			}
		}

		

		private void EmployeeAddNewSaveClick(object sender, EventArgs e)
		{
			if (firstNameAddNewTextbox.Text == null || lastNameAddNewTextbox.Text == null || oibAddNewTextbox.Text == null
			  ||  workPositionAddNewComboBox.SelectedItem==null)
			{
				var emptyEditOrNewFillOutBoxesErrorForm = new EmptyEditOrNewFillOutBoxesErrorForm();
				emptyEditOrNewFillOutBoxesErrorForm.ShowDialog();
			}
			else
			{
				var employee = new Employee(firstNameAddNewTextbox.Text, lastNameAddNewTextbox.Text,
					oibAddNewTextbox.Text, (WorkPosition) workPositionAddNewComboBox.SelectedItem,
					dateOfBirthAddNewDateTimePicker.Value);
				employee.ProjectWithWorkHours = ProjectWithWorkHoursList;
				if (EmployeeRepository.CreateEmployee(employee))
				{
					EmployeeRepository.Employees.Add(employee);
				}

				foreach (var project in ProjectRepository.Projects)
				{


					foreach (var projectWithWorkHours in ProjectWithWorkHoursList)
					{
						if (projectWithWorkHours.Project.Name == project.Name)
						{
							var employeeWithWorkHours1 = new EmployeeWithWorkHours();
							employeeWithWorkHours1.Employee = employee;
							employeeWithWorkHours1.WorkHours = projectWithWorkHours.WorkHours;
							project.EmployeeWithWorkHours.Add(employeeWithWorkHours1);
						}
					}
				}
			}

			//Project.Name = newProjectNameTextBox.Text;
			//Project.StartDate = newProjectStartDateDatePicker.Value;
			//Project.EndDate = newProjectEndDateDatePicker.Value;
			//Project.EmployeeWithWorkHours = EmployeeWithWorkHoursList;
			//ProjectRepository.Projects.Add(Project);
			//foreach (var employee in EmployeeRepository.Employees)
			//{
			//	foreach (var employeeWithWorkHours in EmployeeWithWorkHoursList)
			//	{
			//		if (employeeWithWorkHours.Employee.Oib == employee.Oib)
			//		{
			//			var projectWithWorkHours = new ProjectWithWorkHours();
			//			projectWithWorkHours.Project = Project;
			//			projectWithWorkHours.WorkHours = employeeWithWorkHours.WorkHours;
			//			employee.ProjectWithWorkHours.Add(projectWithWorkHours);
			//		}
			//	}
			//}

			Close();






		}

	

		private void AddProjectToNewEmployeeClick(object sender, EventArgs e)
		{
			if (addWorkHoursToProjectToNewEmployeeNumUpDown.Value == 0) return;
			var projectWithWorkHours = new ProjectWithWorkHours();
			var projectToRemove = projectAddNewComboBox.SelectedItem;
			projectWithWorkHours.Project = projectAddNewComboBox.SelectedItem as Project;
			projectWithWorkHours.WorkHours = (int) addWorkHoursToProjectToNewEmployeeNumUpDown.Value;
			ProjectWithWorkHoursList.Add(projectWithWorkHours);
			projectAddNewComboBox.Items.Remove(projectToRemove);
			projectAddNewComboBox.ResetText();


			

		}
	}
}
