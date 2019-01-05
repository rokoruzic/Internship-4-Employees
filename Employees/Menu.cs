using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void EmployeesDetailsClick(object sender, EventArgs e)
		{
			var employeesDetailsClick = new EmployeesDetails();
			employeesDetailsClick.ShowDialog();
			

		}

		private void EmployeesModifyClick(object sender, EventArgs e)
		{
			var employeesModifyClick = new EmployeesModify();
			employeesModifyClick.ShowDialog();

		}

		private void ProjectDetailsClick(object sender, EventArgs e)
		{
			var projectDetailsClick = new ProjectsDetails();
			projectDetailsClick.ShowDialog();
		}

		private void ProjectsModifyClick(object sender, EventArgs e)
		{
			var projectModifyClick = new ProjectsModify();
			projectModifyClick.ShowDialog();
		}
	}
}
