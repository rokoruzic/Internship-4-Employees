
using System.Windows.Forms;

namespace Employees.Errors
{
	public partial class ErrorForm : Form
	{
		public ErrorForm(string text = "showskirjalestirjalesmirjales")
		{
			InitializeComponent();
			errorLabel.Text = text;
		}
	}
}
