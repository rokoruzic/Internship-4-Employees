using System;
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
using Employees.Errors;

namespace Employees
{
	public partial class ProjectAddNewForm : Form
	{
		public ProjectRepository ProjectRepository;
		public EmployeeRepository EmployeeRepository;
		public List<EmployeeWithWorkHours> EmployeeWithWorkHoursList;
		public List<ProjectWithWorkHours> ProjectWithWorkHoursList;
		public Project Project;
		public ProjectAddNewForm(ProjectRepository projectRepository, EmployeeRepository employeeRepository)
		{
			InitializeComponent();
			ProjectRepository = projectRepository;
			EmployeeRepository = employeeRepository;
			EmployeeWithWorkHoursList = new List<EmployeeWithWorkHours>();
			ProjectWithWorkHoursList = new List<ProjectWithWorkHours>();
			Project=new Project("a",DateTime.Now, DateTime.Now.AddDays(1));
			
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
			if (addWorkHoursToEmployeeNumUpDown.Value == 0 )
			{
				var noWorkHoursError = new NoWorkHoursErrorForm();
				noWorkHoursError.ShowDialog();

			};
			if (projectSelectEmployeesComboBox.SelectedItem == null)
			{
				var noProjectOrEmployeeSelected = new NoProjectOrEmployeeSelected();
				noProjectOrEmployeeSelected.ShowDialog();
				return;

			}
			var employeeWithWorkHours = new EmployeeWithWorkHours();
			var employeeToRemove = projectSelectEmployeesComboBox.SelectedItem;
			employeeWithWorkHours.Employee= projectSelectEmployeesComboBox.SelectedItem as Employee;
			employeeWithWorkHours.WorkHours = (int) addWorkHoursToEmployeeNumUpDown.Value;
			EmployeeWithWorkHoursList.Add(employeeWithWorkHours);
			projectSelectEmployeesComboBox.Items.Remove(employeeToRemove);
			projectSelectEmployeesComboBox.ResetText();
			
		}

		private void ProjectAddNewSaveClick(object sender, EventArgs e)
		{

			if (projectSelectEmployeesComboBox.Items.Count == EmployeeRepository.Employees.Count)
			{
				var noEmployeesInProjectErrorForm = new NoEmployeesInProjectErrorForm();
				noEmployeesInProjectErrorForm.ShowDialog();
				return;
			}
			Project.Name = newProjectNameTextBox.Text;
			Project.StartDate = newProjectStartDateDatePicker.Value;
			Project.EndDate = newProjectEndDateDatePicker.Value;
			Project.EmployeeWithWorkHours = EmployeeWithWorkHoursList;
			if (Project.Name == null )
			{
				var emptyEditOrNewFillOutBoxesErrorForm = new EmptyEditOrNewFillOutBoxesErrorForm();
				emptyEditOrNewFillOutBoxesErrorForm.ShowDialog();
				return;

			}

			if (!Project.IsEndDateAfterStartDate())
			{
				var projectEndDateError = new ProjectEndDateErrorForm();
				projectEndDateError.ShowDialog();
				return;
			}

			if (!ProjectRepository.CreateProject(Project))
			{

				var projectNameDuplicateErrorForm = new ProjectNameDuplicateErrorForm();
				projectNameDuplicateErrorForm.ShowDialog();
				return;
			}
			ProjectRepository.Projects.Add(Project);
		
			foreach (var employee in EmployeeRepository.Employees)
			{
				foreach (var employeeWithWorkHours in EmployeeWithWorkHoursList)
				{
					if(employeeWithWorkHours.Employee.Oib==employee.Oib)
					{
						var projectWithWorkHours = new ProjectWithWorkHours();
						projectWithWorkHours.Project = Project;
						projectWithWorkHours.WorkHours = employeeWithWorkHours.WorkHours;
						employee.ProjectWithWorkHours.Add(projectWithWorkHours);
				}
				}
			}
			
			Close();
		}
	}
}
