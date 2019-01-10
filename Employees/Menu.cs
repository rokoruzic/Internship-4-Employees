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
	public partial class Menu : Form
	{
		public ProjectRepository ProjectRepository { get; set; }
		public EmployeeRepository EmployeeRepository { get; set; }
		public Menu()
		{
			InitializeComponent();
			ProjectRepository=new ProjectRepository();
			EmployeeRepository=new EmployeeRepository();
			var firstEmployee = EmployeeRepository.Employees[0];
			var firstProject = ProjectRepository.Projects[0];

			var projectWithWorkHours = new ProjectWithWorkHours();
			projectWithWorkHours.Project = firstProject;
			projectWithWorkHours.WorkHours = 15;
			firstEmployee.ProjectWithWorkHours.Add(projectWithWorkHours);

			var employeeWithWorkHours = new EmployeeWithWorkHours();
			employeeWithWorkHours.Employee = firstEmployee;
			employeeWithWorkHours.WorkHours = 15;
			firstProject.EmployeeWithWorkHours.Add(employeeWithWorkHours);

		}

		private void employeesDetailsButton_Click(object sender, EventArgs e)
		{
			var employeeListForm = new EmployeeListForm(EmployeeRepository,ProjectRepository);
			employeeListForm.ShowDialog();

		}

		private void ProjectsDetailsButtonClick(object sender, EventArgs e)
		{
			var projectsListForm = new ProjectListForm(ProjectRepository,EmployeeRepository);
			projectsListForm.ShowDialog();
		}
	}
}
