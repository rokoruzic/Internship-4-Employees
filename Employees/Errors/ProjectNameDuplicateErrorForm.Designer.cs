namespace Employees.Errors
{
	partial class ProjectNameDuplicateErrorForm
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
			this.errrorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// errrorLabel
			// 
			this.errrorLabel.AutoSize = true;
			this.errrorLabel.Location = new System.Drawing.Point(264, 72);
			this.errrorLabel.Name = "errrorLabel";
			this.errrorLabel.Size = new System.Drawing.Size(269, 17);
			this.errrorLabel.TabIndex = 0;
			this.errrorLabel.Text = "There is already a project with that name.";
			// 
			// ProjectNameDuplicateErrorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.errrorLabel);
			this.Name = "ProjectNameDuplicateErrorForm";
			this.Text = "ProjectNameDuplicateErrorForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label errrorLabel;
	}
}