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
			foreach (var VARIABLE in SelectedItem.ProjectWithWorkHours)
			{
				ProjectsListBox.Items.Add(VARIABLE);
			}
		}
	}
}
