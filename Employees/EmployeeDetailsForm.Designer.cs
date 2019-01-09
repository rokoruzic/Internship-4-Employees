namespace Employees
{
	partial class EmployeeDetailsForm
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
			this.ProjectsListBox = new System.Windows.Forms.ListBox();
			this.EmployeeTextBox = new System.Windows.Forms.TextBox();
			this.previousProjectsLabel = new System.Windows.Forms.Label();
			this.currentProjectsLabel = new System.Windows.Forms.Label();
			this.plannedProjectsLabel = new System.Windows.Forms.Label();
			this.previousProjectsCount = new System.Windows.Forms.Label();
			this.currentProjectsLabelCount = new System.Windows.Forms.Label();
			this.plannedProjectsLabelCount = new System.Windows.Forms.Label();
			this.employeeDetailsEditButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ProjectsListBox
			// 
			this.ProjectsListBox.FormattingEnabled = true;
			this.ProjectsListBox.ItemHeight = 16;
			this.ProjectsListBox.Location = new System.Drawing.Point(34, 196);
			this.ProjectsListBox.Name = "ProjectsListBox";
			this.ProjectsListBox.Size = new System.Drawing.Size(315, 212);
			this.ProjectsListBox.TabIndex = 0;
			// 
			// EmployeeTextBox
			// 
			this.EmployeeTextBox.Location = new System.Drawing.Point(34, 13);
			this.EmployeeTextBox.Name = "EmployeeTextBox";
			this.EmployeeTextBox.Size = new System.Drawing.Size(315, 22);
			this.EmployeeTextBox.TabIndex = 1;
			// 
			// previousProjectsLabel
			// 
			this.previousProjectsLabel.AutoSize = true;
			this.previousProjectsLabel.Location = new System.Drawing.Point(32, 65);
			this.previousProjectsLabel.Name = "previousProjectsLabel";
			this.previousProjectsLabel.Size = new System.Drawing.Size(121, 17);
			this.previousProjectsLabel.TabIndex = 2;
			this.previousProjectsLabel.Text = "Previous projects:";
			// 
			// currentProjectsLabel
			// 
			this.currentProjectsLabel.AutoSize = true;
			this.currentProjectsLabel.Location = new System.Drawing.Point(32, 102);
			this.currentProjectsLabel.Name = "currentProjectsLabel";
			this.currentProjectsLabel.Size = new System.Drawing.Size(113, 17);
			this.currentProjectsLabel.TabIndex = 3;
			this.currentProjectsLabel.Text = "Current projects:";
			// 
			// plannedProjectsLabel
			// 
			this.plannedProjectsLabel.AutoSize = true;
			this.plannedProjectsLabel.Location = new System.Drawing.Point(32, 137);
			this.plannedProjectsLabel.Name = "plannedProjectsLabel";
			this.plannedProjectsLabel.Size = new System.Drawing.Size(118, 17);
			this.plannedProjectsLabel.TabIndex = 4;
			this.plannedProjectsLabel.Text = "Planned projects:";
			// 
			// previousProjectsCount
			// 
			this.previousProjectsCount.AutoSize = true;
			this.previousProjectsCount.Enabled = false;
			this.previousProjectsCount.Location = new System.Drawing.Point(186, 65);
			this.previousProjectsCount.Name = "previousProjectsCount";
			this.previousProjectsCount.Size = new System.Drawing.Size(0, 17);
			this.previousProjectsCount.TabIndex = 5;
			// 
			// currentProjectsLabelCount
			// 
			this.currentProjectsLabelCount.AutoSize = true;
			this.currentProjectsLabelCount.Enabled = false;
			this.currentProjectsLabelCount.Location = new System.Drawing.Point(189, 102);
			this.currentProjectsLabelCount.Name = "currentProjectsLabelCount";
			this.currentProjectsLabelCount.Size = new System.Drawing.Size(0, 17);
			this.currentProjectsLabelCount.TabIndex = 6;
			// 
			// plannedProjectsLabelCount
			// 
			this.plannedProjectsLabelCount.AutoSize = true;
			this.plannedProjectsLabelCount.Enabled = false;
			this.plannedProjectsLabelCount.Location = new System.Drawing.Point(189, 137);
			this.plannedProjectsLabelCount.Name = "plannedProjectsLabelCount";
			this.plannedProjectsLabelCount.Size = new System.Drawing.Size(0, 17);
			this.plannedProjectsLabelCount.TabIndex = 7;
			// 
			// employeeDetailsEditButton
			// 
			this.employeeDetailsEditButton.Location = new System.Drawing.Point(413, 385);
			this.employeeDetailsEditButton.Name = "employeeDetailsEditButton";
			this.employeeDetailsEditButton.Size = new System.Drawing.Size(104, 23);
			this.employeeDetailsEditButton.TabIndex = 8;
			this.employeeDetailsEditButton.Text = "Edit";
			this.employeeDetailsEditButton.UseVisualStyleBackColor = true;
			this.employeeDetailsEditButton.Click += new System.EventHandler(this.EmployeeDetailsEditButtonClick);
			// 
			// EmployeeDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.employeeDetailsEditButton);
			this.Controls.Add(this.plannedProjectsLabelCount);
			this.Controls.Add(this.currentProjectsLabelCount);
			this.Controls.Add(this.previousProjectsCount);
			this.Controls.Add(this.plannedProjectsLabel);
			this.Controls.Add(this.currentProjectsLabel);
			this.Controls.Add(this.previousProjectsLabel);
			this.Controls.Add(this.EmployeeTextBox);
			this.Controls.Add(this.ProjectsListBox);
			this.Name = "EmployeeDetailsForm";
			this.Text = "EmployeeDetailsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox ProjectsListBox;
		private System.Windows.Forms.TextBox EmployeeTextBox;
		private System.Windows.Forms.Label previousProjectsLabel;
		private System.Windows.Forms.Label currentProjectsLabel;
		private System.Windows.Forms.Label plannedProjectsLabel;
		private System.Windows.Forms.Label previousProjectsCount;
		private System.Windows.Forms.Label currentProjectsLabelCount;
		private System.Windows.Forms.Label plannedProjectsLabelCount;
		private System.Windows.Forms.Button employeeDetailsEditButton;
	}
}