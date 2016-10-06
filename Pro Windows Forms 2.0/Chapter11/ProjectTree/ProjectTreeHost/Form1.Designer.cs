namespace ProjectTreeHost
{
	partial class Form1
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
            this.projectTree1 = new ProjectTreeControl.ProjectTree();
            this.SuspendLayout();
            // 
            // projectTree1
            // 
            this.projectTree1.Location = new System.Drawing.Point(31, 30);
            this.projectTree1.Name = "projectTree1";
            this.projectTree1.SelectedImageIndex = 0;
            this.projectTree1.Size = new System.Drawing.Size(191, 157);
            this.projectTree1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.projectTree1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private ProjectTreeControl.ProjectTree projectTree1;
	}
}

