namespace Employees.Errors
{
	partial class ProjectEndDateErrorForm
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
			this.errorText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// errorText
			// 
			this.errorText.AutoSize = true;
			this.errorText.Location = new System.Drawing.Point(199, 84);
			this.errorText.Name = "errorText";
			this.errorText.Size = new System.Drawing.Size(422, 17);
			this.errorText.TabIndex = 0;
			this.errorText.Text = "Project End date is not valid, it must be after start date. Try again.";
			// 
			// ProjectEndDateErrorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.errorText);
			this.Name = "ProjectEndDateErrorForm";
			this.Text = "ProjectEndDateErrorForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label errorText;
	}
}