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
				return;
			}
			
			
				var employee = new Employee(firstNameAddNewTextbox.Text, lastNameAddNewTextbox.Text,
					oibAddNewTextbox.Text, (WorkPosition) workPositionAddNewComboBox.SelectedItem,
					dateOfBirthAddNewDateTimePicker.Value);
				employee.ProjectWithWorkHours = ProjectWithWorkHoursList;
			if (!EmployeeRepository.CreateEmployee(employee))
			{
				var employeeOibDuplicateErrorForm = new EmployeeOibDuplicateErrorForm();
				employeeOibDuplicateErrorForm.ShowDialog();
				return;
			}
			EmployeeRepository.Employees.Add(employee);
				

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
			
		
			Close();

		}


		private void AddProjectToNewEmployeeClick(object sender, EventArgs e)
		{
			if (projectAddNewComboBox.SelectedItem == null)
			{
				var noProjectOrEmployeeSelected = new NoProjectOrEmployeeSelected();
				noProjectOrEmployeeSelected.ShowDialog();
				return;
			}
			if (addWorkHoursToProjectToNewEmployeeNumUpDown.Value == 0)
			{
				var noWorkHoursError = new NoWorkHoursErrorForm();
				noWorkHoursError.ShowDialog();
				return;
			};
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
