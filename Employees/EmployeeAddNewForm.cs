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
	public partial class EmployeeAddNewForm : Form
	{
		public EmployeeRepository EmployeeRepository;
		public ProjectRepository ProjectRepository;
		public EmployeeAddNewForm(EmployeeRepository employeeRepository, ProjectRepository projectRepository)
		{
			InitializeComponent();
			EmployeeRepository = employeeRepository;
			ProjectRepository = projectRepository;

			foreach (var workPosition in (WorkPosition[])Enum.GetValues(typeof(WorkPosition)))
			{
				workPositionAddNewComboBox.Items.Add(workPosition);
			}
			dateOfBirthAddNewDateTimePicker.MaxDate = DateTime.Now.AddYears(-18);

			if (firstNameAddNewTextbox.Text == null || lastNameAddNewTextbox.Text == null || oibAddNewTextbox.Text == null)
			{
				var EmptyAddEmployeeErrorForm = new EmptyAddEmployeeErrorForm();
				EmptyAddEmployeeErrorForm.ShowDialog();
				ErrorDialog.ShowDialog();
			}

			foreach (var project in ProjectRepository.Projects)
			{
				projectAddNewComboBox.Items.Add(project);
			}

		}

		

		private void EmployeeAddNewSaveClick(object sender, EventArgs e)
		{
			if (firstNameAddNewTextbox.Text == null || lastNameAddNewTextbox.Text == null || oibAddNewTextbox.Text == null
			  ||  workPositionAddNewComboBox.SelectedItem==null)
			{
				var emptyAddEmployeeErrorForm = new EmptyAddEmployeeErrorForm();
				emptyAddEmployeeErrorForm.ShowDialog();
			}
			else
			{
				var employee = new Employee(firstNameAddNewTextbox.Text, lastNameAddNewTextbox.Text,
					oibAddNewTextbox.Text, (WorkPosition) workPositionAddNewComboBox.SelectedItem,
					dateOfBirthAddNewDateTimePicker.Value);
				if (EmployeeRepository.CreateEmployee(employee))
				{
					EmployeeRepository.Employees.Add(employee);
				}
			}
			Close();







		}
	}
}
