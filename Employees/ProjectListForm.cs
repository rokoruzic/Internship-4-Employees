﻿using System;
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
	public partial class ProjectListForm : Form
	{
		public ProjectRepository ProjectRepository { get; set; }
		public EmployeeRepository EmployeeRepository { get; set; }
		public ProjectListForm(ProjectRepository projectRepository,EmployeeRepository employeeRepository)
		{
			InitializeComponent();
			ProjectRepository= projectRepository;
			EmployeeRepository = employeeRepository;

			AddRefreshList();
		}
		public void AddRefreshList()
		{
			projectsListBox.Items.Clear();
			foreach (var project in ProjectRepository.Projects)
			{
				projectsListBox.Items.Add(project);
			}
		}
		private void ProjectEditButtonClick(object sender, EventArgs e)
		{
			var selectedProject = projectsListBox.SelectedItem as Project;
			if (selectedProject == null)
			{
				var errorForm = new ErrorForm("You must select project to edit");
				errorForm.ShowDialog();
				return;
			}
			var projectEditForm = new ProjectEditForm(EmployeeRepository,ProjectRepository) { SelectedProject = selectedProject };
			projectEditForm.SetText();
			projectEditForm.RefreshList();
			AddRefreshList();
			projectEditForm.ShowDialog();

		}

		private void ProjectDeleteClick(object sender, EventArgs e)
		{
			var selectedProject = projectsListBox.SelectedItem as Project;
			if (selectedProject == null)
			{
				var errorForm = new ErrorForm("You must select project to delete");
				errorForm.ShowDialog();
				return;
			}

			ProjectRepository.Projects.Remove(selectedProject);


			foreach (var employee in EmployeeRepository.Employees)
			{
				var listForForeach = employee.ProjectWithWorkHours.ToList();
				foreach (var project in listForForeach)
				{
					employee.ProjectWithWorkHours.Remove(project);
				}

			}

			AddRefreshList();
		}

		private void AddNewProjectClick(object sender, EventArgs e)
		{
			
			var addNewProject = new ProjectAddNewForm(ProjectRepository, EmployeeRepository);
			addNewProject.AddRefreshList();
			AddRefreshList();
			addNewProject.ShowDialog();
		}

		private void ProjectListViewDetailsClick(object sender, EventArgs e)
		{
			var selectedProject = projectsListBox.SelectedItem as Project;
			if (selectedProject == null)
			{
				var errorForm = new ErrorForm("You must select project to view");
				errorForm.ShowDialog();
				return;
			}
			var projectDetailsForm = new ProjectDetailsForm(ProjectRepository,EmployeeRepository){SelectedProject =selectedProject };
			projectDetailsForm.AddRefreshList();
			projectDetailsForm.SetText();
			projectDetailsForm.ShowDialog();
		}
	}
}
