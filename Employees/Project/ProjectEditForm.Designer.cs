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
			this.projectEditSaveButton = new System.Windows.Forms.Button();
			this.projectNameLabel = new System.Windows.Forms.Label();
			this.projectStartDateLabel = new System.Windows.Forms.Label();
			this.projectEndDateLabel = new System.Windows.Forms.Label();
			this.addEmployeeLabel = new System.Windows.Forms.Label();
			this.addWorkHoursLabel = new System.Windows.Forms.Label();
			this.selectEmployeeToDeleteLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.employeeAddWorkHoursNumUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// projectNameTextBox
			// 
			this.projectNameTextBox.Location = new System.Drawing.Point(40, 63);
			this.projectNameTextBox.Name = "projectNameTextBox";
			this.projectNameTextBox.Size = new System.Drawing.Size(189, 22);
			this.projectNameTextBox.TabIndex = 0;
			// 
			// projectStartDateDatePicker
			// 
			this.projectStartDateDatePicker.Location = new System.Drawing.Point(40, 125);
			this.projectStartDateDatePicker.Name = "projectStartDateDatePicker";
			this.projectStartDateDatePicker.Size = new System.Drawing.Size(326, 22);
			this.projectStartDateDatePicker.TabIndex = 1;
			// 
			// projectEndDateDatePicker
			// 
			this.projectEndDateDatePicker.Location = new System.Drawing.Point(40, 199);
			this.projectEndDateDatePicker.Name = "projectEndDateDatePicker";
			this.projectEndDateDatePicker.Size = new System.Drawing.Size(326, 22);
			this.projectEndDateDatePicker.TabIndex = 2;
			// 
			// addEmployeeToProjectComboBox
			// 
			this.addEmployeeToProjectComboBox.FormattingEnabled = true;
			this.addEmployeeToProjectComboBox.Location = new System.Drawing.Point(498, 41);
			this.addEmployeeToProjectComboBox.Name = "addEmployeeToProjectComboBox";
			this.addEmployeeToProjectComboBox.Size = new System.Drawing.Size(230, 24);
			this.addEmployeeToProjectComboBox.TabIndex = 8;
			this.addEmployeeToProjectComboBox.SelectedIndexChanged += new System.EventHandler(this.ShowAddButton);
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
			// projectNameLabel
			// 
			this.projectNameLabel.AutoSize = true;
			this.projectNameLabel.Location = new System.Drawing.Point(37, 26);
			this.projectNameLabel.Name = "projectNameLabel";
			this.projectNameLabel.Size = new System.Drawing.Size(91, 17);
			this.projectNameLabel.TabIndex = 14;
			this.projectNameLabel.Text = "Project name";
			// 
			// projectStartDateLabel
			// 
			this.projectStartDateLabel.AutoSize = true;
			this.projectStartDateLabel.Location = new System.Drawing.Point(37, 97);
			this.projectStartDateLabel.Name = "projectStartDateLabel";
			this.projectStartDateLabel.Size = new System.Drawing.Size(116, 17);
			this.projectStartDateLabel.TabIndex = 15;
			this.projectStartDateLabel.Text = "Project start date";
			// 
			// projectEndDateLabel
			// 
			this.projectEndDateLabel.AutoSize = true;
			this.projectEndDateLabel.Location = new System.Drawing.Point(41, 170);
			this.projectEndDateLabel.Name = "projectEndDateLabel";
			this.projectEndDateLabel.Size = new System.Drawing.Size(112, 17);
			this.projectEndDateLabel.TabIndex = 16;
			this.projectEndDateLabel.Text = "Project end date";
			// 
			// addEmployeeLabel
			// 
			this.addEmployeeLabel.AutoSize = true;
			this.addEmployeeLabel.Location = new System.Drawing.Point(495, 21);
			this.addEmployeeLabel.Name = "addEmployeeLabel";
			this.addEmployeeLabel.Size = new System.Drawing.Size(156, 17);
			this.addEmployeeLabel.TabIndex = 17;
			this.addEmployeeLabel.Text = "Select employee to add";
			// 
			// addWorkHoursLabel
			// 
			this.addWorkHoursLabel.AutoSize = true;
			this.addWorkHoursLabel.Location = new System.Drawing.Point(495, 74);
			this.addWorkHoursLabel.Name = "addWorkHoursLabel";
			this.addWorkHoursLabel.Size = new System.Drawing.Size(106, 17);
			this.addWorkHoursLabel.TabIndex = 18;
			this.addWorkHoursLabel.Text = "Add work hours";
			// 
			// selectEmployeeToDeleteLabel
			// 
			this.selectEmployeeToDeleteLabel.AutoSize = true;
			this.selectEmployeeToDeleteLabel.Location = new System.Drawing.Point(498, 131);
			this.selectEmployeeToDeleteLabel.Name = "selectEmployeeToDeleteLabel";
			this.selectEmployeeToDeleteLabel.Size = new System.Drawing.Size(175, 17);
			this.selectEmployeeToDeleteLabel.TabIndex = 19;
			this.selectEmployeeToDeleteLabel.Text = "Select employee do delete";
			// 
			// ProjectEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.selectEmployeeToDeleteLabel);
			this.Controls.Add(this.addWorkHoursLabel);
			this.Controls.Add(this.addEmployeeLabel);
			this.Controls.Add(this.projectEndDateLabel);
			this.Controls.Add(this.projectStartDateLabel);
			this.Controls.Add(this.projectNameLabel);
			this.Controls.Add(this.projectEditSaveButton);
			this.Controls.Add(this.removeEmployeeFromProjectButton);
			this.Controls.Add(this.addEmployeeToProjectButton);
			this.Controls.Add(this.employeeAddWorkHoursNumUpDown);
			this.Controls.Add(this.removeEmployeeFromProjectComboBox);
			this.Controls.Add(this.addEmployeeToProjectComboBox);
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
		private System.Windows.Forms.Button projectEditSaveButton;
		private System.Windows.Forms.Label projectNameLabel;
		private System.Windows.Forms.Label projectStartDateLabel;
		private System.Windows.Forms.Label projectEndDateLabel;
		private System.Windows.Forms.Label addEmployeeLabel;
		private System.Windows.Forms.Label addWorkHoursLabel;
		private System.Windows.Forms.Label selectEmployeeToDeleteLabel;
	}
}