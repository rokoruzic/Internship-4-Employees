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
	public partial class ProjectEditForm : Form
	{
		public Project SelectedProject { get; set; }
		public EmployeeRepository EmployeeRepository { get; set; }

		public ProjectEditForm()
		{
			InitializeComponent();
			EmployeeRepository = new EmployeeRepository();
			
		}

		public void SetText()
		{
			projectNameTextBox.Text = SelectedProject.Name;
			projectStartDateDatePicker.Value = SelectedProject.StartDate;
			projectEndDateDatePicker.Value = SelectedProject.EndDate;
		}

		public void RefreshList()
		{

			bool isFound;
			foreach (var employee in EmployeeRepository.Employees)
			{
				isFound = false;
				foreach (var employeeWithWorkHours in SelectedProject.EmployeeWithWorkHours)

				{
					if (employeeWithWorkHours.Employee.Oib == employee.Oib)
						isFound = true;

				}

				if (!isFound)
					projectEmployeesComboBox.Items.Add(employee);
			}

			foreach (var selectedProjectEmployeeWithWorkHour in SelectedProject.EmployeeWithWorkHours)
			{
				employeeRemoveComboBox.Items.Add(selectedProjectEmployeeWithWorkHour);
			}


		}
	}
}