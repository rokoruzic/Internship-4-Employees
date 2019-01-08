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
		public ProjectWithWorkHours ProjectWithWorkHours;
		public ProjectRepository ProjectRepository;

		public EmployeeDetailsForm()
		{
			InitializeComponent();
			ProjectWithWorkHours = new ProjectWithWorkHours();
			
			ProjectRepository = new ProjectRepository();
		}

		public void SetText()
		{
			foreach (var project in SelectedItem.ProjectWithWorkHours)
			{
				ProjectsListBox.Items.Add(project);
			}
			if (SelectedItem.WorkHoursCount()>40)
				EmployeeTextBox.BackColor=Color.Red;
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

			
			

			EmployeeTextBox.Text = SelectedItem.PrintFullName();
		}

		
	}
}
