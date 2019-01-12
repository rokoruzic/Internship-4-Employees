using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees.Errors
{
	public partial class ErrorForm : Form
	{
		public ErrorForm(string text = "Error happened.")
		{
			InitializeComponent();
			errorLabel.Text = text;
		}

		public void DuplicateOibText()
		{
			errorLabel.Text = "There already is employee in this project.";

		}

		public void EmptyEditOrNewFillOutBoxesText()
		{
			errorLabel.Text = "Please fill all boxes.";
		}

		public void NoEmployeeInProjectText()
		{
			errorLabel.Text = "There must be atleast one employee in project.";
		}

		public void NoProjectOrEmployeeSelectedText()
		{
			errorLabel.Text = "You need to select item before clicking add.";
		}

		public void NoWorkHoursText()
		{
			errorLabel.Text = "Work hours can't be zero.";
		}

		public void ProjectEndDateText()
		{
			errorLabel.Text = "Project End date is not valid, it must be after start date. Try again.";
		}

		public void ProjectNameDuplicateText()
		{
			errorLabel.Text = "There is already a project with that name.";
		}

		public void OibNotValidText()
		{
			errorLabel.Text = "Oib contains letters and doesn't have 11 characters";
		}


	}
}
