﻿namespace Employees
{
	partial class EmployeeListForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.employeesListBox = new System.Windows.Forms.ListBox();
			this.editSelectedEmployeeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// employeesListBox
			// 
			this.employeesListBox.FormattingEnabled = true;
			this.employeesListBox.ItemHeight = 16;
			this.employeesListBox.Location = new System.Drawing.Point(12, 28);
			this.employeesListBox.Name = "employeesListBox";
			this.employeesListBox.Size = new System.Drawing.Size(500, 372);
			this.employeesListBox.TabIndex = 0;
			// 
			// editSelectedEmployeeButton
			// 
			this.editSelectedEmployeeButton.Location = new System.Drawing.Point(635, 124);
			this.editSelectedEmployeeButton.Name = "editSelectedEmployeeButton";
			this.editSelectedEmployeeButton.Size = new System.Drawing.Size(75, 23);
			this.editSelectedEmployeeButton.TabIndex = 1;
			this.editSelectedEmployeeButton.Text = "Edit";
			this.editSelectedEmployeeButton.UseVisualStyleBackColor = true;
			this.editSelectedEmployeeButton.Click += new System.EventHandler(this.EditEmployeeClick);
			// 
			// EmployeeListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.editSelectedEmployeeButton);
			this.Controls.Add(this.employeesListBox);
			this.Name = "EmployeeListForm";
			this.Text = "EmployeeList";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox employeesListBox;
		private System.Windows.Forms.Button editSelectedEmployeeButton;
	}
}