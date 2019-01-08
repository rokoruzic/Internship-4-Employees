namespace Employees
{
	partial class EmptyAddEmployeeErrorForm
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
			this.emptyAddEmployeeErrorButton = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.emptyTextBoxErrorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// emptyAddEmployeeErrorButton
			// 
			this.emptyAddEmployeeErrorButton.Location = new System.Drawing.Point(323, 186);
			this.emptyAddEmployeeErrorButton.Name = "emptyAddEmployeeErrorButton";
			this.emptyAddEmployeeErrorButton.Size = new System.Drawing.Size(140, 50);
			this.emptyAddEmployeeErrorButton.TabIndex = 1;
			this.emptyAddEmployeeErrorButton.Text = "Back";
			this.emptyAddEmployeeErrorButton.UseVisualStyleBackColor = true;
			this.emptyAddEmployeeErrorButton.Click += new System.EventHandler(this.EmptyEmployeeAddNewErrorBackClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// emptyTextBoxErrorLabel
			// 
			this.emptyTextBoxErrorLabel.AutoSize = true;
			this.emptyTextBoxErrorLabel.Location = new System.Drawing.Point(202, 92);
			this.emptyTextBoxErrorLabel.Name = "emptyTextBoxErrorLabel";
			this.emptyTextBoxErrorLabel.Size = new System.Drawing.Size(398, 17);
			this.emptyTextBoxErrorLabel.TabIndex = 2;
			this.emptyTextBoxErrorLabel.Text = "You didn\'t fill out whole form, press back and please try again.";
			// 
			// EmptyAddEmployeeErrorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.emptyTextBoxErrorLabel);
			this.Controls.Add(this.emptyAddEmployeeErrorButton);
			this.Name = "EmptyAddEmployeeErrorForm";
			this.Text = "EmptyAddEmployeeErrorForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button emptyAddEmployeeErrorButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label emptyTextBoxErrorLabel;
	}
}