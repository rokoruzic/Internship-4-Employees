namespace Employees
{
	partial class EmployeeDetailsForm
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
			this.ProjectsListBox = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// ProjectsListBox
			// 
			this.ProjectsListBox.FormattingEnabled = true;
			this.ProjectsListBox.ItemHeight = 16;
			this.ProjectsListBox.Location = new System.Drawing.Point(34, 196);
			this.ProjectsListBox.Name = "ProjectsListBox";
			this.ProjectsListBox.Size = new System.Drawing.Size(315, 212);
			this.ProjectsListBox.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(34, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(315, 22);
			this.textBox1.TabIndex = 1;
			// 
			// EmployeeDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.ProjectsListBox);
			this.Name = "EmployeeDetailsForm";
			this.Text = "EmployeeDetailsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox ProjectsListBox;
		private System.Windows.Forms.TextBox textBox1;
	}
}