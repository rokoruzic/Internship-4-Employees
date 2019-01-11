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
	public partial class ProjectListForm : Form
	{
		public ProjectRepository ProjectRepository { get; set; }
		public EmployeeRepository EmployeeRepository { get; set; }
		public ProjectListForm(ProjectRepository projectRepository,EmployeeRepository employeeRepository)
		{
			InitializeComponent();
			ProjectRepository= projectRepository;
			EmployeeRepository = employeeRepository;

			foreach (var project in ProjectRepository.Projects)
			{
				projectsListBox.Items.Add(project);
			}
		}

		private void ProjectEditButtonClick(object sender, EventArgs e)
		{
			var selectedProject = projectsListBox.SelectedItem as Project;
			if (selectedProject == null) return;
			var projectEditForm = new ProjectEditForm(EmployeeRepository) { SelectedProject = selectedProject };
			projectEditForm.SetText();
			projectEditForm.RefreshList();
			projectEditForm.ShowDialog();

		}

		private void ProjectDeleteClick(object sender, EventArgs e)
		{
			var selectedProject1 = projectsListBox.SelectedItem as Project;
			if (selectedProject1 == null) return;

			ProjectRepository.Projects.Remove(selectedProject1);


			foreach (var employee in EmployeeRepository.Employees)
			{
				var listForForeach = employee.ProjectWithWorkHours.ToList();
				foreach (var project in listForForeach)
				{
					employee.ProjectWithWorkHours.Remove(project);
				}

			}

			
			Close();
		}

		private void AddNewProjectClick(object sender, EventArgs e)
		{
			
			var addNewProject = new ProjectAddNewForm(ProjectRepository, EmployeeRepository);
			addNewProject.AddRefreshList();
			addNewProject.ShowDialog();
		}

		private void ProjectListViewDetailsClick(object sender, EventArgs e)
		{
			var selectedProject = projectsListBox.SelectedItem as Project;
			var projectDetailsForm = new ProjectDetailsForm(ProjectRepository){SelectedProject =selectedProject };
			projectDetailsForm.AddRefreshList();
			projectDetailsForm.ShowDialog();
		}
	}
}
