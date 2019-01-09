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
		public ProjectRepository ProjectRepository;
		public ProjectListForm(ProjectRepository projectRepository)
		{
			InitializeComponent();
			ProjectRepository= projectRepository;
			foreach (var project in ProjectRepository.Projects)
			{
				projectsListBox.Items.Add(project);
			}
		}

		private void projectEditButtonClick(object sender, EventArgs e)
		{
			var selectedProject = projectsListBox.SelectedItem as Project;
			if (selectedProject == null) return;
			var projectEditForm = new ProjectEditForm() { SelectedProject = selectedProject };
			projectEditForm.SetText();
			projectEditForm.RefreshList();
			projectEditForm.ShowDialog();

		}
	}
}
