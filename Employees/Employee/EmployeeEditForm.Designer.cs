namespace Employees
{
	partial class EmployeeEditForm
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
			this.employeeEditFirstNameTextBox = new System.Windows.Forms.TextBox();
			this.employeeLastNameEditTextBox = new System.Windows.Forms.TextBox();
			this.employeeEditWorkPositionComboBox = new System.Windows.Forms.ComboBox();
			this.employeeEditDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.employeeEditSaveButton = new System.Windows.Forms.Button();
			this.addProjectToEmployeeComboBox = new System.Windows.Forms.ComboBox();
			this.RemoveProjectFromEmployeeComboBox = new System.Windows.Forms.ComboBox();
			this.weeklyWorkingHoursLabel = new System.Windows.Forms.Label();
			this.addProjectToNewEmployeeButton = new System.Windows.Forms.Button();
			this.workHoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.employeeDeleteProjectButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.workHoursNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// employeeEditFirstNameTextBox
			// 
			this.employeeEditFirstNameTextBox.Location = new System.Drawing.Point(86, 57);
			this.employeeEditFirstNameTextBox.Name = "employeeEditFirstNameTextBox";
			this.employeeEditFirstNameTextBox.Size = new System.Drawing.Size(217, 22);
			this.employeeEditFirstNameTextBox.TabIndex = 0;
			// 
			// employeeLastNameEditTextBox
			// 
			this.employeeLastNameEditTextBox.Location = new System.Drawing.Point(86, 118);
			this.employeeLastNameEditTextBox.Name = "employeeLastNameEditTextBox";
			this.employeeLastNameEditTextBox.Size = new System.Drawing.Size(217, 22);
			this.employeeLastNameEditTextBox.TabIndex = 1;
			// 
			// employeeEditWorkPositionComboBox
			// 
			this.employeeEditWorkPositionComboBox.FormattingEnabled = true;
			this.employeeEditWorkPositionComboBox.Location = new System.Drawing.Point(86, 170);
			this.employeeEditWorkPositionComboBox.Name = "employeeEditWorkPositionComboBox";
			this.employeeEditWorkPositionComboBox.Size = new System.Drawing.Size(217, 24);
			this.employeeEditWorkPositionComboBox.TabIndex = 4;
			// 
			// employeeEditDateTimePicker
			// 
			this.employeeEditDateTimePicker.Location = new System.Drawing.Point(27, 242);
			this.employeeEditDateTimePicker.Name = "employeeEditDateTimePicker";
			this.employeeEditDateTimePicker.Size = new System.Drawing.Size(306, 22);
			this.employeeEditDateTimePicker.TabIndex = 5;
			// 
			// employeeEditSaveButton
			// 
			this.employeeEditSaveButton.Location = new System.Drawing.Point(360, 387);
			this.employeeEditSaveButton.Name = "employeeEditSaveButton";
			this.employeeEditSaveButton.Size = new System.Drawing.Size(75, 23);
			this.employeeEditSaveButton.TabIndex = 6;
			this.employeeEditSaveButton.Text = "Save";
			this.employeeEditSaveButton.UseVisualStyleBackColor = true;
			this.employeeEditSaveButton.Click += new System.EventHandler(this.EmployeeEditSaveButton);
			// 
			// addProjectToEmployeeComboBox
			// 
			this.addProjectToEmployeeComboBox.FormattingEnabled = true;
			this.addProjectToEmployeeComboBox.Location = new System.Drawing.Point(476, 57);
			this.addProjectToEmployeeComboBox.Name = "addProjectToEmployeeComboBox";
			this.addProjectToEmployeeComboBox.Size = new System.Drawing.Size(279, 24);
			this.addProjectToEmployeeComboBox.TabIndex = 7;
			this.addProjectToEmployeeComboBox.Click += new System.EventHandler(this.AddProjectToEmployeeComboBox_Click);
			// 
			// RemoveProjectFromEmployeeComboBox
			// 
			this.RemoveProjectFromEmployeeComboBox.FormattingEnabled = true;
			this.RemoveProjectFromEmployeeComboBox.Location = new System.Drawing.Point(476, 195);
			this.RemoveProjectFromEmployeeComboBox.Name = "RemoveProjectFromEmployeeComboBox";
			this.RemoveProjectFromEmployeeComboBox.Size = new System.Drawing.Size(278, 24);
			this.RemoveProjectFromEmployeeComboBox.TabIndex = 8;
			// 
			// weeklyWorkingHoursLabel
			// 
			this.weeklyWorkingHoursLabel.AutoSize = true;
			this.weeklyWorkingHoursLabel.Location = new System.Drawing.Point(473, 99);
			this.weeklyWorkingHoursLabel.Name = "weeklyWorkingHoursLabel";
			this.weeklyWorkingHoursLabel.Size = new System.Drawing.Size(180, 17);
			this.weeklyWorkingHoursLabel.TabIndex = 11;
			this.weeklyWorkingHoursLabel.Text = "Enter weekly working hours";
			// 
			// addProjectToNewEmployeeButton
			// 
			this.addProjectToNewEmployeeButton.Location = new System.Drawing.Point(689, 117);
			this.addProjectToNewEmployeeButton.Name = "addProjectToNewEmployeeButton";
			this.addProjectToNewEmployeeButton.Size = new System.Drawing.Size(75, 23);
			this.addProjectToNewEmployeeButton.TabIndex = 12;
			this.addProjectToNewEmployeeButton.Text = "Add";
			this.addProjectToNewEmployeeButton.UseVisualStyleBackColor = true;
			this.addProjectToNewEmployeeButton.Click += new System.EventHandler(this.AddProjectToEmployeeClick);
			// 
			// workHoursNumericUpDown
			// 
			this.workHoursNumericUpDown.Location = new System.Drawing.Point(476, 119);
			this.workHoursNumericUpDown.Name = "workHoursNumericUpDown";
			this.workHoursNumericUpDown.Size = new System.Drawing.Size(177, 22);
			this.workHoursNumericUpDown.TabIndex = 13;
			// 
			// employeeDeleteProjectButton
			// 
			this.employeeDeleteProjectButton.Location = new System.Drawing.Point(476, 240);
			this.employeeDeleteProjectButton.Name = "employeeDeleteProjectButton";
			this.employeeDeleteProjectButton.Size = new System.Drawing.Size(75, 23);
			this.employeeDeleteProjectButton.TabIndex = 14;
			this.employeeDeleteProjectButton.Text = "Delete project";
			this.employeeDeleteProjectButton.UseVisualStyleBackColor = true;
			this.employeeDeleteProjectButton.Click += new System.EventHandler(this.EmployeeDeleteProjectClick);
			// 
			// EmployeeEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.employeeDeleteProjectButton);
			this.Controls.Add(this.workHoursNumericUpDown);
			this.Controls.Add(this.addProjectToNewEmployeeButton);
			this.Controls.Add(this.weeklyWorkingHoursLabel);
			this.Controls.Add(this.RemoveProjectFromEmployeeComboBox);
			this.Controls.Add(this.addProjectToEmployeeComboBox);
			this.Controls.Add(this.employeeEditSaveButton);
			this.Controls.Add(this.employeeEditDateTimePicker);
			this.Controls.Add(this.employeeEditWorkPositionComboBox);
			this.Controls.Add(this.employeeLastNameEditTextBox);
			this.Controls.Add(this.employeeEditFirstNameTextBox);
			this.Name = "EmployeeEditForm";
			this.Text = "EmployeeEditForm";
			((System.ComponentModel.ISupportInitialize)(this.workHoursNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox employeeEditFirstNameTextBox;
		private System.Windows.Forms.TextBox employeeLastNameEditTextBox;
		private System.Windows.Forms.ComboBox employeeEditWorkPositionComboBox;
		private System.Windows.Forms.DateTimePicker employeeEditDateTimePicker;
		private System.Windows.Forms.Button employeeEditSaveButton;
		private System.Windows.Forms.ComboBox addProjectToEmployeeComboBox;
		private System.Windows.Forms.ComboBox RemoveProjectFromEmployeeComboBox;
		private System.Windows.Forms.Label weeklyWorkingHoursLabel;
		private System.Windows.Forms.Button addProjectToNewEmployeeButton;
		private System.Windows.Forms.NumericUpDown workHoursNumericUpDown;
		private System.Windows.Forms.Button employeeDeleteProjectButton;
	}
}