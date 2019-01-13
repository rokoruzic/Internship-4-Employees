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

namespace Employees
{
	public partial class EmployeeDetailsForm : Form
	{
		public Employee SelectedItem { get; set; }
		public ProjectWithWorkHours ProjectWithWorkHours{get; set; }
		public ProjectRepository ProjectRepository { get; set; }
		public EmployeeRepository EmployeeRepository { get; set; }

		public EmployeeDetailsForm(ProjectRepository projectRepository,EmployeeRepository employeeRepository)
		{
			InitializeComponent();
			ProjectWithWorkHours = new ProjectWithWorkHours();

			ProjectRepository = projectRepository;
			EmployeeRepository = employeeRepository;
		}

		public void SetText()
		{
			foreach (var project in SelectedItem.ProjectWithWorkHours)
			{
				ProjectsListBox.Items.Add(project);
			}

			if (SelectedItem.WorkHoursCount() > 40)
				EmployeeTextBox.BackColor = Color.Red;
			else if (SelectedItem.WorkHoursCount() < 30)
				EmployeeTextBox.BackColor = Color.Yellow;
			else if (SelectedItem.WorkHoursCount() >= 30 && SelectedItem.WorkHoursCount() < 41)
				EmployeeTextBox.BackColor = Color.Green;
			var numberOfPreviousProjectsCount = SelectedItem.NumberOfPreviousProjects().ToString();
			var numberOfCurrentProjectsCount = SelectedItem.NumberOfCurrentProjects().ToString();
			var numberOfPlannedProjectsCount = SelectedItem.NumberOfPlannedProjects().ToString();
			previousProjectsCount.Text = numberOfPreviousProjectsCount;
			currentProjectsLabelCount.Text = numberOfCurrentProjectsCount;
			plannedProjectsLabelCount.Text = numberOfPlannedProjectsCount;


			EmployeeTextBox.Text = SelectedItem.PrintEmployeeWIthWorkhours();
		}

		private void EmployeeDetailsEditButtonClick(object sender, EventArgs e)
		{
			var selectedEmployee = SelectedItem as Employee;
			if (selectedEmployee == null) return;
			Close();

			var employeeEditForm = new EmployeeEditForm(ProjectRepository,EmployeeRepository) {SelectedEmployee = selectedEmployee};
			employeeEditForm.EditedEmployeeSetText();
			employeeEditForm.RefreshList();

			employeeEditForm.ShowDialog();
		}
	}
}
