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
		public Project	SelectedProject { get; set; }
		public ProjectDetailsForm(ProjectRepository projectRepository)
		{
			InitializeComponent();
			ProjectRepository = projectRepository;
		}

		public void AddRefreshList()
		{
			foreach (var employeeWithWorkHours in SelectedProject.EmployeeWithWorkHours)
			{
				
				if (employeeWithWorkHours.Employee.WorkPosition == WorkPosition.Developer)
					workPositionDeveloperListBox.Items.Add(employeeWithWorkHours);
				else if (employeeWithWorkHours.Employee.WorkPosition == WorkPosition.WebDeveloper)
					workPositionWebDeveloperListBox.Items.Add(employeeWithWorkHours);
				else if (employeeWithWorkHours.Employee.WorkPosition == WorkPosition.Manager)
					workPositionManagerListBox.Items.Add(employeeWithWorkHours);
				else if (employeeWithWorkHours.Employee.WorkPosition == WorkPosition.Accountant)
					workPositionAccountantListBox.Items.Add(employeeWithWorkHours);
				else workPositionSecretaryListBox.Items.Add(employeeWithWorkHours);
				
			}
		}
	}
}
