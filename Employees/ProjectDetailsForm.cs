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
	public partial class ProjectDetailsForm : Form
	{
		public ProjectRepository ProjectRepository { get; set; }
		public EmployeeRepository EmployeeRepository { get; set; }
		public Project	SelectedProject { get; set; }
		public ProjectDetailsForm(ProjectRepository projectRepository, EmployeeRepository employeeRepository)
		{
			InitializeComponent();
			ProjectRepository = projectRepository;
			EmployeeRepository = employeeRepository;

		}

		public void AddRefreshList()
		{
			var list = SelectedProject.EmployeeWithWorkHours.ToList();
			foreach (var employeeWithWorkHours in list)
			{

				if (employeeWithWorkHours.Employee.WorkPosition == WorkPosition.Developer)
				{
					workPositionDeveloperListBox.Items.Add(employeeWithWorkHours);
					
				}
				else if (employeeWithWorkHours.Employee.WorkPosition == WorkPosition.WebDeveloper)
					workPositionWebDeveloperListBox.Items.Add(employeeWithWorkHours);
				else if (employeeWithWorkHours.Employee.WorkPosition == WorkPosition.Manager)
					workPositionManagerListBox.Items.Add(employeeWithWorkHours);
				else if (employeeWithWorkHours.Employee.WorkPosition == WorkPosition.Accountant)
					workPositionAccountantListBox.Items.Add(employeeWithWorkHours);
				else workPositionSecretaryListBox.Items.Add(employeeWithWorkHours);
				
			}
		}

		public void SetText()
		{
			projectName.Text = SelectedProject.Name;
			var workPositionDeveloperCount = workPositionDeveloperListBox.Items.Count.ToString();
			var workPositionWebDeveloperCount = workPositionWebDeveloperListBox.Items.Count.ToString();
			var workPositionAccountantCount = workPositionAccountantListBox.Items.Count.ToString();
			var workPositionManagerCount = workPositionManagerListBox.Items.Count.ToString();
			var workPositionSecretaryCount = workPositionSecretaryListBox.Items.Count.ToString();
			if (workPositionDeveloperListBox.Items.Count == 0)
			{
				workPositionDeveloperListBox.Hide();
				developerTextBox.Hide();
			}

			if (workPositionWebDeveloperListBox.Items.Count == 0)
			{
				workPositionWebDeveloperListBox.Hide();
				webDeveloperTextBox.Hide();
			}

			if (workPositionAccountantListBox.Items.Count == 0)
			{
				workPositionAccountantListBox.Hide();
				accountantTextBox.Hide();
			}

			if (workPositionSecretaryListBox.Items.Count == 0)
			{
				workPositionSecretaryListBox.Hide();
				secretaryTextBox.Hide();
			}

			if (workPositionManagerListBox.Items.Count == 0)
			{
				workPositionManagerListBox.Hide();
				managerTextBox.Hide();
			}
			accountantTextBox.Text = $"Accountant({workPositionAccountantCount})";
			managerTextBox.Text = $"Manager({workPositionManagerCount})";
			developerTextBox.Text = $"Developer({workPositionDeveloperCount})";
			webDeveloperTextBox.Text = $"Web Developer({workPositionWebDeveloperCount})";
			secretaryTextBox.Text = $"Secretary({workPositionSecretaryCount})";

		}

		private void ProjectEditClick(object sender, EventArgs e)
		{
			var selectedProject = SelectedProject as Project;
			if (selectedProject == null) return;
			Close();

			var employeeEditForm = new ProjectEditForm(EmployeeRepository,ProjectRepository) { SelectedProject = selectedProject };
			employeeEditForm.SetText();
			employeeEditForm.RefreshList();
			employeeEditForm.ShowDialog();
		}
	}
}
