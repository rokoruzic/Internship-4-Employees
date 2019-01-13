namespace Employees.Warnings
{
	partial class EmployeeDeleteWarningForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.employeeDeleteNoButton = new System.Windows.Forms.Button();
			this.employeeDeleteYesButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(234, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(281, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Are you sure you want to delete employee?";
			// 
			// employeeDeleteNoButton
			// 
			this.employeeDeleteNoButton.Location = new System.Drawing.Point(391, 159);
			this.employeeDeleteNoButton.Name = "employeeDeleteNoButton";
			this.employeeDeleteNoButton.Size = new System.Drawing.Size(75, 23);
			this.employeeDeleteNoButton.TabIndex = 1;
			this.employeeDeleteNoButton.Text = "No";
			this.employeeDeleteNoButton.UseVisualStyleBackColor = true;
			this.employeeDeleteNoButton.Click += new System.EventHandler(this.EmployeeDeleteNoClick);
			// 
			// employeeDeleteYesButton
			// 
			this.employeeDeleteYesButton.Location = new System.Drawing.Point(280, 159);
			this.employeeDeleteYesButton.Name = "employeeDeleteYesButton";
			this.employeeDeleteYesButton.Size = new System.Drawing.Size(75, 23);
			this.employeeDeleteYesButton.TabIndex = 2;
			this.employeeDeleteYesButton.Text = "Yes";
			this.employeeDeleteYesButton.UseVisualStyleBackColor = true;
			this.employeeDeleteYesButton.Click += new System.EventHandler(this.EmployeeButtonYesClick);
			// 
			// EmployeeDeleteWarningForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.employeeDeleteYesButton);
			this.Controls.Add(this.employeeDeleteNoButton);
			this.Controls.Add(this.label1);
			this.Name = "EmployeeDeleteWarningForm";
			this.Text = "EmployeeDeleteWarningForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button employeeDeleteNoButton;
		private System.Windows.Forms.Button employeeDeleteYesButton;
	}
}