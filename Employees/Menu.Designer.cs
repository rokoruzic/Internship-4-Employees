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
			this.modifyEmployeesButton = new System.Windows.Forms.Button();
			this.ProjectsDetailsButton = new System.Windows.Forms.Button();
			this.modifyProjectsButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// employeesDetailsButton
			// 
			this.employeesDetailsButton.Location = new System.Drawing.Point(166, 54);
			this.employeesDetailsButton.Name = "employeesDetailsButton";
			this.employeesDetailsButton.Size = new System.Drawing.Size(466, 73);
			this.employeesDetailsButton.TabIndex = 0;
			this.employeesDetailsButton.Text = "Employees details";
			this.employeesDetailsButton.UseVisualStyleBackColor = true;
			// 
			// modifyEmployeesButton
			// 
			this.modifyEmployeesButton.Location = new System.Drawing.Point(166, 153);
			this.modifyEmployeesButton.Name = "modifyEmployeesButton";
			this.modifyEmployeesButton.Size = new System.Drawing.Size(466, 75);
			this.modifyEmployeesButton.TabIndex = 1;
			this.modifyEmployeesButton.Text = "Modify employees";
			this.modifyEmployeesButton.UseVisualStyleBackColor = true;
			// 
			// ProjectsDetailsButton
			// 
			this.ProjectsDetailsButton.Location = new System.Drawing.Point(166, 259);
			this.ProjectsDetailsButton.Name = "ProjectsDetailsButton";
			this.ProjectsDetailsButton.Size = new System.Drawing.Size(466, 70);
			this.ProjectsDetailsButton.TabIndex = 2;
			this.ProjectsDetailsButton.Text = "Projects details";
			this.ProjectsDetailsButton.UseVisualStyleBackColor = true;
			// 
			// modifyProjectsButton
			// 
			this.modifyProjectsButton.Location = new System.Drawing.Point(166, 357);
			this.modifyProjectsButton.Name = "modifyProjectsButton";
			this.modifyProjectsButton.Size = new System.Drawing.Size(466, 69);
			this.modifyProjectsButton.TabIndex = 3;
			this.modifyProjectsButton.Text = "Modify projects";
			this.modifyProjectsButton.UseVisualStyleBackColor = true;
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.modifyProjectsButton);
			this.Controls.Add(this.ProjectsDetailsButton);
			this.Controls.Add(this.modifyEmployeesButton);
			this.Controls.Add(this.employeesDetailsButton);
			this.Name = "Menu";
			this.Text = "Menu";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button employeesDetailsButton;
		private System.Windows.Forms.Button modifyEmployeesButton;
		private System.Windows.Forms.Button ProjectsDetailsButton;
		private System.Windows.Forms.Button modifyProjectsButton;
	}
}