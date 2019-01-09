namespace Employees
{
	partial class ProjectListForm
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
			this.projectsListBox = new System.Windows.Forms.ListBox();
			this.projectEditButton = new System.Windows.Forms.Button();
			this.projectDeleteButton = new System.Windows.Forms.Button();
			this.projectDetailsButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// projectsListBox
			// 
			this.projectsListBox.FormattingEnabled = true;
			this.projectsListBox.ItemHeight = 16;
			this.projectsListBox.Location = new System.Drawing.Point(0, 12);
			this.projectsListBox.Name = "projectsListBox";
			this.projectsListBox.Size = new System.Drawing.Size(467, 436);
			this.projectsListBox.TabIndex = 0;
			// 
			// projectEditButton
			// 
			this.projectEditButton.Location = new System.Drawing.Point(672, 92);
			this.projectEditButton.Name = "projectEditButton";
			this.projectEditButton.Size = new System.Drawing.Size(75, 23);
			this.projectEditButton.TabIndex = 1;
			this.projectEditButton.Text = "Edit";
			this.projectEditButton.UseVisualStyleBackColor = true;
			this.projectEditButton.Click += new System.EventHandler(this.projectEditButtonClick);
			// 
			// projectDeleteButton
			// 
			this.projectDeleteButton.Location = new System.Drawing.Point(672, 156);
			this.projectDeleteButton.Name = "projectDeleteButton";
			this.projectDeleteButton.Size = new System.Drawing.Size(75, 23);
			this.projectDeleteButton.TabIndex = 2;
			this.projectDeleteButton.Text = "Delete";
			this.projectDeleteButton.UseVisualStyleBackColor = true;
			// 
			// projectDetailsButton
			// 
			this.projectDetailsButton.Location = new System.Drawing.Point(672, 235);
			this.projectDetailsButton.Name = "projectDetailsButton";
			this.projectDetailsButton.Size = new System.Drawing.Size(75, 23);
			this.projectDetailsButton.TabIndex = 3;
			this.projectDetailsButton.Text = "View";
			this.projectDetailsButton.UseVisualStyleBackColor = true;
			// 
			// ProjectListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.projectDetailsButton);
			this.Controls.Add(this.projectDeleteButton);
			this.Controls.Add(this.projectEditButton);
			this.Controls.Add(this.projectsListBox);
			this.Name = "ProjectListForm";
			this.Text = "ProjectListForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox projectsListBox;
		private System.Windows.Forms.Button projectEditButton;
		private System.Windows.Forms.Button projectDeleteButton;
		private System.Windows.Forms.Button projectDetailsButton;
	}
}