namespace Employees
{
	partial class ProjectAddNewForm
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
			this.newProjectNameTextBox = new System.Windows.Forms.TextBox();
			this.newProjectStartDateDatePicker = new System.Windows.Forms.DateTimePicker();
			this.newProjectEndDateDatePicker = new System.Windows.Forms.DateTimePicker();
			this.projectSelectEmployeesComboBox = new System.Windows.Forms.ComboBox();
			this.addWorkHoursToEmployeeNumUpDown = new System.Windows.Forms.NumericUpDown();
			this.employeeAddToProjectButton = new System.Windows.Forms.Button();
			this.projectAddNewSaveButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.addWorkHoursToEmployeeNumUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// newProjectNameTextBox
			// 
			this.newProjectNameTextBox.Location = new System.Drawing.Point(12, 71);
			this.newProjectNameTextBox.Name = "newProjectNameTextBox";
			this.newProjectNameTextBox.Size = new System.Drawing.Size(147, 22);
			this.newProjectNameTextBox.TabIndex = 0;
			// 
			// newProjectStartDateDatePicker
			// 
			this.newProjectStartDateDatePicker.Location = new System.Drawing.Point(12, 138);
			this.newProjectStartDateDatePicker.Name = "newProjectStartDateDatePicker";
			this.newProjectStartDateDatePicker.Size = new System.Drawing.Size(200, 22);
			this.newProjectStartDateDatePicker.TabIndex = 1;
			// 
			// newProjectEndDateDatePicker
			// 
			this.newProjectEndDateDatePicker.Location = new System.Drawing.Point(12, 218);
			this.newProjectEndDateDatePicker.Name = "newProjectEndDateDatePicker";
			this.newProjectEndDateDatePicker.Size = new System.Drawing.Size(200, 22);
			this.newProjectEndDateDatePicker.TabIndex = 2;
			// 
			// projectSelectEmployeesComboBox
			// 
			this.projectSelectEmployeesComboBox.FormattingEnabled = true;
			this.projectSelectEmployeesComboBox.Location = new System.Drawing.Point(522, 71);
			this.projectSelectEmployeesComboBox.Name = "projectSelectEmployeesComboBox";
			this.projectSelectEmployeesComboBox.Size = new System.Drawing.Size(217, 24);
			this.projectSelectEmployeesComboBox.TabIndex = 4;
			// 
			// addWorkHoursToEmployeeNumUpDown
			// 
			this.addWorkHoursToEmployeeNumUpDown.Location = new System.Drawing.Point(522, 137);
			this.addWorkHoursToEmployeeNumUpDown.Name = "addWorkHoursToEmployeeNumUpDown";
			this.addWorkHoursToEmployeeNumUpDown.Size = new System.Drawing.Size(120, 22);
			this.addWorkHoursToEmployeeNumUpDown.TabIndex = 5;
			// 
			// employeeAddToProjectButton
			// 
			this.employeeAddToProjectButton.Location = new System.Drawing.Point(664, 137);
			this.employeeAddToProjectButton.Name = "employeeAddToProjectButton";
			this.employeeAddToProjectButton.Size = new System.Drawing.Size(75, 23);
			this.employeeAddToProjectButton.TabIndex = 6;
			this.employeeAddToProjectButton.Text = "Add";
			this.employeeAddToProjectButton.UseVisualStyleBackColor = true;
			this.employeeAddToProjectButton.Click += new System.EventHandler(this.EmployeeAddToProjectClick);
			// 
			// projectAddNewSaveButton
			// 
			this.projectAddNewSaveButton.Location = new System.Drawing.Point(278, 388);
			this.projectAddNewSaveButton.Name = "projectAddNewSaveButton";
			this.projectAddNewSaveButton.Size = new System.Drawing.Size(181, 23);
			this.projectAddNewSaveButton.TabIndex = 8;
			this.projectAddNewSaveButton.Text = "Save";
			this.projectAddNewSaveButton.UseVisualStyleBackColor = true;
			this.projectAddNewSaveButton.Click += new System.EventHandler(this.ProjectAddNewSaveClick);
			// 
			// ProjectAddNewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.projectAddNewSaveButton);
			this.Controls.Add(this.employeeAddToProjectButton);
			this.Controls.Add(this.addWorkHoursToEmployeeNumUpDown);
			this.Controls.Add(this.projectSelectEmployeesComboBox);
			this.Controls.Add(this.newProjectEndDateDatePicker);
			this.Controls.Add(this.newProjectStartDateDatePicker);
			this.Controls.Add(this.newProjectNameTextBox);
			this.Name = "ProjectAddNewForm";
			this.Text = "AddNewProjectForm";
			((System.ComponentModel.ISupportInitialize)(this.addWorkHoursToEmployeeNumUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox newProjectNameTextBox;
		private System.Windows.Forms.DateTimePicker newProjectStartDateDatePicker;
		private System.Windows.Forms.DateTimePicker newProjectEndDateDatePicker;
		private System.Windows.Forms.ComboBox projectSelectEmployeesComboBox;
		private System.Windows.Forms.NumericUpDown addWorkHoursToEmployeeNumUpDown;
		private System.Windows.Forms.Button employeeAddToProjectButton;
		private System.Windows.Forms.Button projectAddNewSaveButton;
	}
}