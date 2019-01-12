﻿using System;
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
	}
}