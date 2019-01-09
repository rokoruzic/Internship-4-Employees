namespace Employees
{
	partial class Menu
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
			this.employeesDetailsButton = new System.Windows.Forms.Button();
			this.ProjectsDetailsButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// employeesDetailsButton
			// 
			this.employeesDetailsButton.Location = new System.Drawing.Point(166, 53);
			this.employeesDetailsButton.Name = "employeesDetailsButton";
			this.employeesDetailsButton.Size = new System.Drawing.Size(466, 73);
			this.employeesDetailsButton.TabIndex = 0;
			this.employeesDetailsButton.Text = "Employees";
			this.employeesDetailsButton.UseVisualStyleBackColor = true;
			this.employeesDetailsButton.Click += new System.EventHandler(this.employeesDetailsButton_Click);
			// 
			// ProjectsDetailsButton
			// 
			this.ProjectsDetailsButton.Location = new System.Drawing.Point(166, 175);
			this.ProjectsDetailsButton.Name = "ProjectsDetailsButton";
			this.ProjectsDetailsButton.Size = new System.Drawing.Size(466, 70);
			this.ProjectsDetailsButton.TabIndex = 2;
			this.ProjectsDetailsButton.Text = "Projects";
			this.ProjectsDetailsButton.UseVisualStyleBackColor = true;
			this.ProjectsDetailsButton.Click += new System.EventHandler(this.ProjectsDetailsButtonClick);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ProjectsDetailsButton);
			this.Controls.Add(this.employeesDetailsButton);
			this.Name = "Menu";
			this.Text = "Menu";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button employeesDetailsButton;
		private System.Windows.Forms.Button ProjectsDetailsButton;
	}
}