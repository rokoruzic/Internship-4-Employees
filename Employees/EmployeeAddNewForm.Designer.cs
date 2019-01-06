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
			this.SuspendLayout();
			// 
			// firstNameAddNewTextbox
			// 
			this.firstNameAddNewTextbox.Location = new System.Drawing.Point(277, 51);
			this.firstNameAddNewTextbox.Name = "firstNameAddNewTextbox";
			this.firstNameAddNewTextbox.Size = new System.Drawing.Size(195, 22);
			this.firstNameAddNewTextbox.TabIndex = 0;
			// 
			// lastNameAddNewTextbox
			// 
			this.lastNameAddNewTextbox.Location = new System.Drawing.Point(277, 107);
			this.lastNameAddNewTextbox.Name = "lastNameAddNewTextbox";
			this.lastNameAddNewTextbox.Size = new System.Drawing.Size(195, 22);
			this.lastNameAddNewTextbox.TabIndex = 1;
			// 
			// oibAddNewTextbox
			// 
			this.oibAddNewTextbox.Location = new System.Drawing.Point(277, 167);
			this.oibAddNewTextbox.Name = "oibAddNewTextbox";
			this.oibAddNewTextbox.Size = new System.Drawing.Size(195, 22);
			this.oibAddNewTextbox.TabIndex = 2;
			// 
			// dateOfBirthAddNewDateTimePicker
			// 
			this.dateOfBirthAddNewDateTimePicker.Location = new System.Drawing.Point(172, 233);
			this.dateOfBirthAddNewDateTimePicker.Name = "dateOfBirthAddNewDateTimePicker";
			this.dateOfBirthAddNewDateTimePicker.Size = new System.Drawing.Size(444, 22);
			this.dateOfBirthAddNewDateTimePicker.TabIndex = 5;
			// 
			// workPositionAddNewComboBox
			// 
			this.workPositionAddNewComboBox.FormattingEnabled = true;
			this.workPositionAddNewComboBox.Location = new System.Drawing.Point(277, 311);
			this.workPositionAddNewComboBox.Name = "workPositionAddNewComboBox";
			this.workPositionAddNewComboBox.Size = new System.Drawing.Size(195, 24);
			this.workPositionAddNewComboBox.TabIndex = 6;
			// 
			// employeeSaveAddNewButton
			// 
			this.employeeSaveAddNewButton.Location = new System.Drawing.Point(632, 392);
			this.employeeSaveAddNewButton.Name = "employeeSaveAddNewButton";
			this.employeeSaveAddNewButton.Size = new System.Drawing.Size(75, 23);
			this.employeeSaveAddNewButton.TabIndex = 7;
			this.employeeSaveAddNewButton.Text = "Save";
			this.employeeSaveAddNewButton.UseVisualStyleBackColor = true;
			this.employeeSaveAddNewButton.Click += new System.EventHandler(this.EmployeeAddNewSaveClick);
			// 
			// EmployeeAddNewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.employeeSaveAddNewButton);
			this.Controls.Add(this.workPositionAddNewComboBox);
			this.Controls.Add(this.dateOfBirthAddNewDateTimePicker);
			this.Controls.Add(this.oibAddNewTextbox);
			this.Controls.Add(this.lastNameAddNewTextbox);
			this.Controls.Add(this.firstNameAddNewTextbox);
			this.Name = "EmployeeAddNewForm";
			this.Text = "EmployeeAddNewForm";
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
	}
}