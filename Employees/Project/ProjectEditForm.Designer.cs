namespace Employees
{
	partial class ProjectEditForm
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
			this.projectNameTextBox = new System.Windows.Forms.TextBox();
			this.projectStartDateDatePicker = new System.Windows.Forms.DateTimePicker();
			this.projectEndDateDatePicker = new System.Windows.Forms.DateTimePicker();
			this.addEmployeeToProjectComboBox = new System.Windows.Forms.ComboBox();
			this.removeEmployeeFromProjectComboBox = new System.Windows.Forms.ComboBox();
			this.employeeAddWorkHoursNumUpDown = new System.Windows.Forms.NumericUpDown();
			this.addEmployeeToProjectButton = new System.Windows.Forms.Button();
			this.removeEmployeeFromProjectButton = new System.Windows.Forms.Button();
			this.weeklyWorkHoursLabel = new System.Windows.Forms.Label();
			this.projectEditSaveButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.employeeAddWorkHoursNumUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// projectNameTextBox
			// 
			this.projectNameTextBox.Location = new System.Drawing.Point(49, 45);
			this.projectNameTextBox.Name = "projectNameTextBox";
			this.projectNameTextBox.Size = new System.Drawing.Size(265, 22);
			this.projectNameTextBox.TabIndex = 0;
			// 
			// projectStartDateDatePicker
			// 
			this.projectStartDateDatePicker.Location = new System.Drawing.Point(49, 124);
			this.projectStartDateDatePicker.Name = "projectStartDateDatePicker";
			this.projectStartDateDatePicker.Size = new System.Drawing.Size(256, 22);
			this.projectStartDateDatePicker.TabIndex = 1;
			// 
			// projectEndDateDatePicker
			// 
			this.projectEndDateDatePicker.Location = new System.Drawing.Point(49, 198);
			this.projectEndDateDatePicker.Name = "projectEndDateDatePicker";
			this.projectEndDateDatePicker.Size = new System.Drawing.Size(256, 22);
			this.projectEndDateDatePicker.TabIndex = 2;
			// 
			// addEmployeeToProjectComboBox
			// 
			this.addEmployeeToProjectComboBox.FormattingEnabled = true;
			this.addEmployeeToProjectComboBox.Location = new System.Drawing.Point(498, 41);
			this.addEmployeeToProjectComboBox.Name = "addEmployeeToProjectComboBox";
			this.addEmployeeToProjectComboBox.Size = new System.Drawing.Size(230, 24);
			this.addEmployeeToProjectComboBox.TabIndex = 8;
			this.addEmployeeToProjectComboBox.Click += new System.EventHandler(this.AddEmployeeToProjectComboBoxClick);
			// 
			// removeEmployeeFromProjectComboBox
			// 
			this.removeEmployeeFromProjectComboBox.FormattingEnabled = true;
			this.removeEmployeeFromProjectComboBox.Location = new System.Drawing.Point(498, 154);
			this.removeEmployeeFromProjectComboBox.Name = "removeEmployeeFromProjectComboBox";
			this.removeEmployeeFromProjectComboBox.Size = new System.Drawing.Size(230, 24);
			this.removeEmployeeFromProjectComboBox.TabIndex = 9;
			// 
			// employeeAddWorkHoursNumUpDown
			// 
			this.employeeAddWorkHoursNumUpDown.Location = new System.Drawing.Point(498, 94);
			this.employeeAddWorkHoursNumUpDown.Name = "employeeAddWorkHoursNumUpDown";
			this.employeeAddWorkHoursNumUpDown.Size = new System.Drawing.Size(120, 22);
			this.employeeAddWorkHoursNumUpDown.TabIndex = 10;
			// 
			// addEmployeeToProjectButton
			// 
			this.addEmployeeToProjectButton.Location = new System.Drawing.Point(652, 94);
			this.addEmployeeToProjectButton.Name = "addEmployeeToProjectButton";
			this.addEmployeeToProjectButton.Size = new System.Drawing.Size(75, 23);
			this.addEmployeeToProjectButton.TabIndex = 11;
			this.addEmployeeToProjectButton.Text = "Add";
			this.addEmployeeToProjectButton.UseVisualStyleBackColor = true;
			this.addEmployeeToProjectButton.Click += new System.EventHandler(this.AddEmployeeToProjectClick);
			// 
			// removeEmployeeFromProjectButton
			// 
			this.removeEmployeeFromProjectButton.Location = new System.Drawing.Point(498, 220);
			this.removeEmployeeFromProjectButton.Name = "removeEmployeeFromProjectButton";
			this.removeEmployeeFromProjectButton.Size = new System.Drawing.Size(75, 23);
			this.removeEmployeeFromProjectButton.TabIndex = 12;
			this.removeEmployeeFromProjectButton.Text = "Delete";
			this.removeEmployeeFromProjectButton.UseVisualStyleBackColor = true;
			this.removeEmployeeFromProjectButton.Click += new System.EventHandler(this.RemoveEmployeeFromProjectClick);
			// 
			// weeklyWorkHoursLabel
			// 
			this.weeklyWorkHoursLabel.AutoSize = true;
			this.weeklyWorkHoursLabel.Enabled = false;
			this.weeklyWorkHoursLabel.Location = new System.Drawing.Point(495, 68);
			this.weeklyWorkHoursLabel.Name = "weeklyWorkHoursLabel";
			this.weeklyWorkHoursLabel.Size = new System.Drawing.Size(161, 17);
			this.weeklyWorkHoursLabel.TabIndex = 6;
			this.weeklyWorkHoursLabel.Text = "Type work hours below.:";
			// 
			// projectEditSaveButton
			// 
			this.projectEditSaveButton.Location = new System.Drawing.Point(362, 376);
			this.projectEditSaveButton.Name = "projectEditSaveButton";
			this.projectEditSaveButton.Size = new System.Drawing.Size(75, 23);
			this.projectEditSaveButton.TabIndex = 13;
			this.projectEditSaveButton.Text = "Save";
			this.projectEditSaveButton.UseVisualStyleBackColor = true;
			this.projectEditSaveButton.Click += new System.EventHandler(this.ProjectEditSaveClick);
			// 
			// ProjectEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.projectEditSaveButton);
			this.Controls.Add(this.removeEmployeeFromProjectButton);
			this.Controls.Add(this.addEmployeeToProjectButton);
			this.Controls.Add(this.employeeAddWorkHoursNumUpDown);
			this.Controls.Add(this.removeEmployeeFromProjectComboBox);
			this.Controls.Add(this.addEmployeeToProjectComboBox);
			this.Controls.Add(this.weeklyWorkHoursLabel);
			this.Controls.Add(this.projectEndDateDatePicker);
			this.Controls.Add(this.projectStartDateDatePicker);
			this.Controls.Add(this.projectNameTextBox);
			this.Name = "ProjectEditForm";
			this.Text = "ProjectEditForm";
			((System.ComponentModel.ISupportInitialize)(this.employeeAddWorkHoursNumUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox projectNameTextBox;
		private System.Windows.Forms.DateTimePicker projectStartDateDatePicker;
		private System.Windows.Forms.DateTimePicker projectEndDateDatePicker;
		private System.Windows.Forms.ComboBox addEmployeeToProjectComboBox;
		private System.Windows.Forms.ComboBox removeEmployeeFromProjectComboBox;
		private System.Windows.Forms.NumericUpDown employeeAddWorkHoursNumUpDown;
		private System.Windows.Forms.Button addEmployeeToProjectButton;
		private System.Windows.Forms.Button removeEmployeeFromProjectButton;
		private System.Windows.Forms.Label weeklyWorkHoursLabel;
		private System.Windows.Forms.Button projectEditSaveButton;
	}
}