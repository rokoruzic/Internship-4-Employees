namespace Employees
{
	partial class EmployeeAddNewForm
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
			this.firstNameAddNewTextbox = new System.Windows.Forms.TextBox();
			this.lastNameAddNewTextbox = new System.Windows.Forms.TextBox();
			this.oibAddNewTextbox = new System.Windows.Forms.TextBox();
			this.dateOfBirthAddNewDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.workPositionAddNewComboBox = new System.Windows.Forms.ComboBox();
			this.employeeSaveAddNewButton = new System.Windows.Forms.Button();
			this.ErrorDialog = new System.Windows.Forms.OpenFileDialog();
			this.projectAddNewComboBox = new System.Windows.Forms.ComboBox();
			this.addWorkHoursToProjectToNewEmployeeNumUpDown = new System.Windows.Forms.NumericUpDown();
			this.addProjectToNewEmployeeButton = new System.Windows.Forms.Button();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.oibLabel = new System.Windows.Forms.Label();
			this.addProjectLabel = new System.Windows.Forms.Label();
			this.workHoursLabel = new System.Windows.Forms.Label();
			this.workPositionLabel = new System.Windows.Forms.Label();
			this.dateOfBirthLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.addWorkHoursToProjectToNewEmployeeNumUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// firstNameAddNewTextbox
			// 
			this.firstNameAddNewTextbox.Location = new System.Drawing.Point(28, 45);
			this.firstNameAddNewTextbox.Name = "firstNameAddNewTextbox";
			this.firstNameAddNewTextbox.Size = new System.Drawing.Size(195, 22);
			this.firstNameAddNewTextbox.TabIndex = 0;
			// 
			// lastNameAddNewTextbox
			// 
			this.lastNameAddNewTextbox.Location = new System.Drawing.Point(28, 96);
			this.lastNameAddNewTextbox.Name = "lastNameAddNewTextbox";
			this.lastNameAddNewTextbox.Size = new System.Drawing.Size(195, 22);
			this.lastNameAddNewTextbox.TabIndex = 1;
			// 
			// oibAddNewTextbox
			// 
			this.oibAddNewTextbox.Location = new System.Drawing.Point(28, 156);
			this.oibAddNewTextbox.Name = "oibAddNewTextbox";
			this.oibAddNewTextbox.Size = new System.Drawing.Size(195, 22);
			this.oibAddNewTextbox.TabIndex = 2;
			// 
			// dateOfBirthAddNewDateTimePicker
			// 
			this.dateOfBirthAddNewDateTimePicker.Location = new System.Drawing.Point(28, 237);
			this.dateOfBirthAddNewDateTimePicker.Name = "dateOfBirthAddNewDateTimePicker";
			this.dateOfBirthAddNewDateTimePicker.Size = new System.Drawing.Size(379, 22);
			this.dateOfBirthAddNewDateTimePicker.TabIndex = 5;
			// 
			// workPositionAddNewComboBox
			// 
			this.workPositionAddNewComboBox.FormattingEnabled = true;
			this.workPositionAddNewComboBox.Location = new System.Drawing.Point(28, 293);
			this.workPositionAddNewComboBox.Name = "workPositionAddNewComboBox";
			this.workPositionAddNewComboBox.Size = new System.Drawing.Size(195, 24);
			this.workPositionAddNewComboBox.TabIndex = 6;
			// 
			// employeeSaveAddNewButton
			// 
			this.employeeSaveAddNewButton.Location = new System.Drawing.Point(389, 395);
			this.employeeSaveAddNewButton.Name = "employeeSaveAddNewButton";
			this.employeeSaveAddNewButton.Size = new System.Drawing.Size(75, 23);
			this.employeeSaveAddNewButton.TabIndex = 7;
			this.employeeSaveAddNewButton.Text = "Save";
			this.employeeSaveAddNewButton.UseVisualStyleBackColor = true;
			this.employeeSaveAddNewButton.Click += new System.EventHandler(this.EmployeeAddNewSaveClick);
			// 
			// ErrorDialog
			// 
			this.ErrorDialog.FileName = "EmptyAddEmployeeErrorForm";
			// 
			// projectAddNewComboBox
			// 
			this.projectAddNewComboBox.FormattingEnabled = true;
			this.projectAddNewComboBox.Location = new System.Drawing.Point(500, 45);
			this.projectAddNewComboBox.Name = "projectAddNewComboBox";
			this.projectAddNewComboBox.Size = new System.Drawing.Size(212, 24);
			this.projectAddNewComboBox.TabIndex = 8;
			this.projectAddNewComboBox.SelectedIndexChanged += new System.EventHandler(this.ProjectAddNewSelectItem);
			// 
			// addWorkHoursToProjectToNewEmployeeNumUpDown
			// 
			this.addWorkHoursToProjectToNewEmployeeNumUpDown.Location = new System.Drawing.Point(500, 110);
			this.addWorkHoursToProjectToNewEmployeeNumUpDown.Name = "addWorkHoursToProjectToNewEmployeeNumUpDown";
			this.addWorkHoursToProjectToNewEmployeeNumUpDown.Size = new System.Drawing.Size(78, 22);
			this.addWorkHoursToProjectToNewEmployeeNumUpDown.TabIndex = 9;
			// 
			// addProjectToNewEmployeeButton
			// 
			this.addProjectToNewEmployeeButton.Location = new System.Drawing.Point(637, 110);
			this.addProjectToNewEmployeeButton.Name = "addProjectToNewEmployeeButton";
			this.addProjectToNewEmployeeButton.Size = new System.Drawing.Size(75, 23);
			this.addProjectToNewEmployeeButton.TabIndex = 10;
			this.addProjectToNewEmployeeButton.Text = "Add";
			this.addProjectToNewEmployeeButton.UseVisualStyleBackColor = true;
			this.addProjectToNewEmployeeButton.Click += new System.EventHandler(this.AddProjectToNewEmployeeClick);
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Location = new System.Drawing.Point(25, 25);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(74, 17);
			this.firstNameLabel.TabIndex = 11;
			this.firstNameLabel.Text = "First name";
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Location = new System.Drawing.Point(25, 76);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(74, 17);
			this.lastNameLabel.TabIndex = 12;
			this.lastNameLabel.Text = "Last name";
			// 
			// oibLabel
			// 
			this.oibLabel.AutoSize = true;
			this.oibLabel.Location = new System.Drawing.Point(25, 136);
			this.oibLabel.Name = "oibLabel";
			this.oibLabel.Size = new System.Drawing.Size(31, 17);
			this.oibLabel.TabIndex = 13;
			this.oibLabel.Text = "OIB";
			// 
			// addProjectLabel
			// 
			this.addProjectLabel.AutoSize = true;
			this.addProjectLabel.Location = new System.Drawing.Point(497, 25);
			this.addProjectLabel.Name = "addProjectLabel";
			this.addProjectLabel.Size = new System.Drawing.Size(138, 17);
			this.addProjectLabel.TabIndex = 14;
			this.addProjectLabel.Text = "Select project to add";
			// 
			// workHoursLabel
			// 
			this.workHoursLabel.AutoSize = true;
			this.workHoursLabel.Location = new System.Drawing.Point(497, 81);
			this.workHoursLabel.Name = "workHoursLabel";
			this.workHoursLabel.Size = new System.Drawing.Size(106, 17);
			this.workHoursLabel.TabIndex = 15;
			this.workHoursLabel.Text = "Add work hours";
			// 
			// workPositionLabel
			// 
			this.workPositionLabel.AutoSize = true;
			this.workPositionLabel.Location = new System.Drawing.Point(25, 273);
			this.workPositionLabel.Name = "workPositionLabel";
			this.workPositionLabel.Size = new System.Drawing.Size(94, 17);
			this.workPositionLabel.TabIndex = 16;
			this.workPositionLabel.Text = "Work position";
			// 
			// dateOfBirthLabel
			// 
			this.dateOfBirthLabel.AutoSize = true;
			this.dateOfBirthLabel.Location = new System.Drawing.Point(25, 207);
			this.dateOfBirthLabel.Name = "dateOfBirthLabel";
			this.dateOfBirthLabel.Size = new System.Drawing.Size(86, 17);
			this.dateOfBirthLabel.TabIndex = 17;
			this.dateOfBirthLabel.Text = "Date of birth";
			// 
			// EmployeeAddNewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dateOfBirthLabel);
			this.Controls.Add(this.workPositionLabel);
			this.Controls.Add(this.workHoursLabel);
			this.Controls.Add(this.addProjectLabel);
			this.Controls.Add(this.oibLabel);
			this.Controls.Add(this.lastNameLabel);
			this.Controls.Add(this.firstNameLabel);
			this.Controls.Add(this.addProjectToNewEmployeeButton);
			this.Controls.Add(this.addWorkHoursToProjectToNewEmployeeNumUpDown);
			this.Controls.Add(this.projectAddNewComboBox);
			this.Controls.Add(this.employeeSaveAddNewButton);
			this.Controls.Add(this.workPositionAddNewComboBox);
			this.Controls.Add(this.dateOfBirthAddNewDateTimePicker);
			this.Controls.Add(this.oibAddNewTextbox);
			this.Controls.Add(this.lastNameAddNewTextbox);
			this.Controls.Add(this.firstNameAddNewTextbox);
			this.Name = "EmployeeAddNewForm";
			this.Text = "EmployeeAddNewForm";
			((System.ComponentModel.ISupportInitialize)(this.addWorkHoursToProjectToNewEmployeeNumUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox firstNameAddNewTextbox;
		private System.Windows.Forms.TextBox lastNameAddNewTextbox;
		private System.Windows.Forms.TextBox oibAddNewTextbox;
		private System.Windows.Forms.DateTimePicker dateOfBirthAddNewDateTimePicker;
		private System.Windows.Forms.ComboBox workPositionAddNewComboBox;
		private System.Windows.Forms.Button employeeSaveAddNewButton;
		private System.Windows.Forms.OpenFileDialog ErrorDialog;
		private System.Windows.Forms.ComboBox projectAddNewComboBox;
		private System.Windows.Forms.NumericUpDown addWorkHoursToProjectToNewEmployeeNumUpDown;
		private System.Windows.Forms.Button addProjectToNewEmployeeButton;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.Label oibLabel;
		private System.Windows.Forms.Label addProjectLabel;
		private System.Windows.Forms.Label workHoursLabel;
		private System.Windows.Forms.Label workPositionLabel;
		private System.Windows.Forms.Label dateOfBirthLabel;
	}
}