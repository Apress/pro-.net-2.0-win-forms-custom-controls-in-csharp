namespace LocalizableControl
{
	partial class LocalizableUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.localizable = new System.Windows.Forms.Label();
            this.nonLocalizable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // localizable
            // 
            this.localizable.AutoSize = true;
            this.localizable.Location = new System.Drawing.Point(14, 23);
            this.localizable.Name = "localizable";
            this.localizable.Size = new System.Drawing.Size(56, 13);
            this.localizable.TabIndex = 0;
            this.localizable.Text = "localizable";
            // 
            // nonLocalizable
            // 
            this.nonLocalizable.AutoSize = true;
            this.nonLocalizable.Location = new System.Drawing.Point(14, 59);
            this.nonLocalizable.Name = "nonLocalizable";
            this.nonLocalizable.Size = new System.Drawing.Size(78, 13);
            this.nonLocalizable.TabIndex = 1;
            this.nonLocalizable.Text = "nonLocalizable";
            // 
            // LocalizableUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nonLocalizable);
            this.Controls.Add(this.localizable);
            this.Name = "LocalizableUserControl";
            this.Size = new System.Drawing.Size(265, 220);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Label localizable;
        private System.Windows.Forms.Label nonLocalizable;
	}
}
