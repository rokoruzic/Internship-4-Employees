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
			this.SuspendLayout();
			// 
			// employeeEditFirstNameTextBox
			// 
			this.employeeEditFirstNameTextBox.Location = new System.Drawing.Point(263, 58);
			this.employeeEditFirstNameTextBox.Name = "employeeEditFirstNameTextBox";
			this.employeeEditFirstNameTextBox.Size = new System.Drawing.Size(217, 22);
			this.employeeEditFirstNameTextBox.TabIndex = 0;
			// 
			// employeeLastNameEditTextBox
			// 
			this.employeeLastNameEditTextBox.Location = new System.Drawing.Point(263, 109);
			this.employeeLastNameEditTextBox.Name = "employeeLastNameEditTextBox";
			this.employeeLastNameEditTextBox.Size = new System.Drawing.Size(217, 22);
			this.employeeLastNameEditTextBox.TabIndex = 1;
			// 
			// employeeEditWorkPositionComboBox
			// 
			this.employeeEditWorkPositionComboBox.FormattingEnabled = true;
			this.employeeEditWorkPositionComboBox.Location = new System.Drawing.Point(263, 169);
			this.employeeEditWorkPositionComboBox.Name = "employeeEditWorkPositionComboBox";
			this.employeeEditWorkPositionComboBox.Size = new System.Drawing.Size(217, 24);
			this.employeeEditWorkPositionComboBox.TabIndex = 4;
			// 
			// employeeEditDateTimePicker
			// 
			this.employeeEditDateTimePicker.Location = new System.Drawing.Point(181, 234);
			this.employeeEditDateTimePicker.Name = "employeeEditDateTimePicker";
			this.employeeEditDateTimePicker.Size = new System.Drawing.Size(516, 22);
			this.employeeEditDateTimePicker.TabIndex = 5;
			// 
			// employeeEditSaveButton
			// 
			this.employeeEditSaveButton.Location = new System.Drawing.Point(332, 350);
			this.employeeEditSaveButton.Name = "employeeEditSaveButton";
			this.employeeEditSaveButton.Size = new System.Drawing.Size(75, 23);
			this.employeeEditSaveButton.TabIndex = 6;
			this.employeeEditSaveButton.Text = "Save";
			this.employeeEditSaveButton.UseVisualStyleBackColor = true;
			this.employeeEditSaveButton.Click += new System.EventHandler(this.EmployeeEditSaveButton);
			// 
			// EmployeeEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.employeeEditSaveButton);
			this.Controls.Add(this.employeeEditDateTimePicker);
			this.Controls.Add(this.employeeEditWorkPositionComboBox);
			this.Controls.Add(this.employeeLastNameEditTextBox);
			this.Controls.Add(this.employeeEditFirstNameTextBox);
			this.Name = "EmployeeEditForm";
			this.Text = "EmployeeEditForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox employeeEditFirstNameTextBox;
		private System.Windows.Forms.TextBox employeeLastNameEditTextBox;
		private System.Windows.Forms.ComboBox employeeEditWorkPositionComboBox;
		private System.Windows.Forms.DateTimePicker employeeEditDateTimePicker;
		private System.Windows.Forms.Button employeeEditSaveButton;
	}
}