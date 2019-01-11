namespace Employees
{
	partial class ProjectDetailsForm
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
			this.workPositionManagerListBox = new System.Windows.Forms.ListBox();
			this.workPositionDeveloperListBox = new System.Windows.Forms.ListBox();
			this.workPositionSecretaryListBox = new System.Windows.Forms.ListBox();
			this.workPositionWebDeveloperListBox = new System.Windows.Forms.ListBox();
			this.workPositionAccountantListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// workPositionManagerListBox
			// 
			this.workPositionManagerListBox.FormattingEnabled = true;
			this.workPositionManagerListBox.ItemHeight = 16;
			this.workPositionManagerListBox.Location = new System.Drawing.Point(33, 132);
			this.workPositionManagerListBox.Name = "workPositionManagerListBox";
			this.workPositionManagerListBox.Size = new System.Drawing.Size(206, 132);
			this.workPositionManagerListBox.TabIndex = 0;
			// 
			// workPositionDeveloperListBox
			// 
			this.workPositionDeveloperListBox.FormattingEnabled = true;
			this.workPositionDeveloperListBox.ItemHeight = 16;
			this.workPositionDeveloperListBox.Location = new System.Drawing.Point(33, 306);
			this.workPositionDeveloperListBox.Name = "workPositionDeveloperListBox";
			this.workPositionDeveloperListBox.Size = new System.Drawing.Size(206, 132);
			this.workPositionDeveloperListBox.TabIndex = 1;
			// 
			// workPositionSecretaryListBox
			// 
			this.workPositionSecretaryListBox.FormattingEnabled = true;
			this.workPositionSecretaryListBox.ItemHeight = 16;
			this.workPositionSecretaryListBox.Location = new System.Drawing.Point(338, 132);
			this.workPositionSecretaryListBox.Name = "workPositionSecretaryListBox";
			this.workPositionSecretaryListBox.Size = new System.Drawing.Size(191, 132);
			this.workPositionSecretaryListBox.TabIndex = 2;
			// 
			// workPositionWebDeveloperListBox
			// 
			this.workPositionWebDeveloperListBox.FormattingEnabled = true;
			this.workPositionWebDeveloperListBox.ItemHeight = 16;
			this.workPositionWebDeveloperListBox.Location = new System.Drawing.Point(338, 306);
			this.workPositionWebDeveloperListBox.Name = "workPositionWebDeveloperListBox";
			this.workPositionWebDeveloperListBox.Size = new System.Drawing.Size(185, 132);
			this.workPositionWebDeveloperListBox.TabIndex = 3;
			// 
			// workPositionAccountantListBox
			// 
			this.workPositionAccountantListBox.FormattingEnabled = true;
			this.workPositionAccountantListBox.ItemHeight = 16;
			this.workPositionAccountantListBox.Location = new System.Drawing.Point(597, 132);
			this.workPositionAccountantListBox.Name = "workPositionAccountantListBox";
			this.workPositionAccountantListBox.Size = new System.Drawing.Size(166, 132);
			this.workPositionAccountantListBox.TabIndex = 4;
			// 
			// ProjectDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.workPositionAccountantListBox);
			this.Controls.Add(this.workPositionWebDeveloperListBox);
			this.Controls.Add(this.workPositionSecretaryListBox);
			this.Controls.Add(this.workPositionDeveloperListBox);
			this.Controls.Add(this.workPositionManagerListBox);
			this.Name = "ProjectDetailsForm";
			this.Text = "ProjectDetailsForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox workPositionManagerListBox;
		private System.Windows.Forms.ListBox workPositionDeveloperListBox;
		private System.Windows.Forms.ListBox workPositionSecretaryListBox;
		private System.Windows.Forms.ListBox workPositionWebDeveloperListBox;
		private System.Windows.Forms.ListBox workPositionAccountantListBox;
	}
}