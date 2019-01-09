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
			this.projectEmployeesComboBox = new System.Windows.Forms.ComboBox();
			this.employeeWorkHoursNumUpDown = new System.Windows.Forms.NumericUpDown();
			this.employeeAddToProjectButton = new System.Windows.Forms.Button();
			this.weeklyWorkHoursLabel = new System.Windows.Forms.Label();
			this.employeeRemoveComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.employeeWorkHoursNumUpDown)).BeginInit();
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
			// projectEmployeesComboBox
			// 
			this.projectEmployeesComboBox.FormattingEnabled = true;
			this.projectEmployeesComboBox.Location = new System.Drawing.Point(39, 248);
			this.projectEmployeesComboBox.Name = "projectEmployeesComboBox";
			this.projectEmployeesComboBox.Size = new System.Drawing.Size(275, 24);
			this.projectEmployeesComboBox.TabIndex = 3;
			// 
			// employeeWorkHoursNumUpDown
			// 
			this.employeeWorkHoursNumUpDown.Location = new System.Drawing.Point(39, 324);
			this.employeeWorkHoursNumUpDown.Name = "employeeWorkHoursNumUpDown";
			this.employeeWorkHoursNumUpDown.Size = new System.Drawing.Size(120, 22);
			this.employeeWorkHoursNumUpDown.TabIndex = 4;
			// 
			// employeeAddToProjectButton
			// 
			this.employeeAddToProjectButton.Location = new System.Drawing.Point(39, 352);
			this.employeeAddToProjectButton.Name = "employeeAddToProjectButton";
			this.employeeAddToProjectButton.Size = new System.Drawing.Size(120, 23);
			this.employeeAddToProjectButton.TabIndex = 5;
			this.employeeAddToProjectButton.Text = "Add employee";
			this.employeeAddToProjectButton.UseVisualStyleBackColor = true;
			// 
			// weeklyWorkHoursLabel
			// 
			this.weeklyWorkHoursLabel.AutoSize = true;
			this.weeklyWorkHoursLabel.Enabled = false;
			this.weeklyWorkHoursLabel.Location = new System.Drawing.Point(36, 291);
			this.weeklyWorkHoursLabel.Name = "weeklyWorkHoursLabel";
			this.weeklyWorkHoursLabel.Size = new System.Drawing.Size(161, 17);
			this.weeklyWorkHoursLabel.TabIndex = 6;
			this.weeklyWorkHoursLabel.Text = "Type work hours below.:";
			// 
			// employeeRemoveComboBox
			// 
			this.employeeRemoveComboBox.FormattingEnabled = true;
			this.employeeRemoveComboBox.Location = new System.Drawing.Point(38, 392);
			this.employeeRemoveComboBox.Name = "employeeRemoveComboBox";
			this.employeeRemoveComboBox.Size = new System.Drawing.Size(276, 24);
			this.employeeRemoveComboBox.TabIndex = 7;
			// 
			// ProjectEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.employeeRemoveComboBox);
			this.Controls.Add(this.weeklyWorkHoursLabel);
			this.Controls.Add(this.employeeAddToProjectButton);
			this.Controls.Add(this.employeeWorkHoursNumUpDown);
			this.Controls.Add(this.projectEmployeesComboBox);
			this.Controls.Add(this.projectEndDateDatePicker);
			this.Controls.Add(this.projectStartDateDatePicker);
			this.Controls.Add(this.projectNameTextBox);
			this.Name = "ProjectEditForm";
			this.Text = "ProjectEditForm";
			((System.ComponentModel.ISupportInitialize)(this.employeeWorkHoursNumUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox projectNameTextBox;
		private System.Windows.Forms.DateTimePicker projectStartDateDatePicker;
		private System.Windows.Forms.DateTimePicker projectEndDateDatePicker;
		private System.Windows.Forms.ComboBox projectEmployeesComboBox;
		private System.Windows.Forms.NumericUpDown employeeWorkHoursNumUpDown;
		private System.Windows.Forms.Button employeeAddToProjectButton;
		private System.Windows.Forms.Label weeklyWorkHoursLabel;
		private System.Windows.Forms.ComboBox employeeRemoveComboBox;
	}
}