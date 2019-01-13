using System;
using System.Windows.Forms;
using ClassLibrary1.Models;
using Employees.Domain.Repositories;
using Employees.Errors;

namespace Employees.Warnings
{
	public partial class EmployeeDeleteWarningForm : Form
	{
		public Employee SelectedEmployee { get; set; }
		public ProjectRepository ProjectRepository { get; set; }
		public EmployeeRepository EmployeeRepository { get; set; }

		public EmployeeDeleteWarningForm(EmployeeRepository employeeRepository, ProjectRepository projectRepository)
		{
			InitializeComponent();
			EmployeeRepository = employeeRepository;
			ProjectRepository = projectRepository;
		}

		private void EmployeeDeleteNoClick(object sender, EventArgs e)
		{
			var employeeListForm = new EmployeeListForm(EmployeeRepository, ProjectRepository);
			Close();
			employeeListForm.ShowDialog();
		}

		private void EmployeeButtonYesClick(object sender, EventArgs e)
		{
			var result = EmployeeRepository.Delete(SelectedEmployee, ProjectRepository);
			if (result != null)
			{
				var errorForm = new ErrorForm(result);
				errorForm.ShowDialog();
				return;
			}

			Close();
		}
	}
}
