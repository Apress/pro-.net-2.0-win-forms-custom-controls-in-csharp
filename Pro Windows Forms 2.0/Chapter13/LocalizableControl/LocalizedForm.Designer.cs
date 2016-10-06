namespace LocalizableControl
{
	partial class LocalizedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizedForm));
            this.localizableUserControl2 = new LocalizableControl.LocalizableUserControl();
            this.localizableUserControl1 = new LocalizableControl.LocalizableUserControl();
            this.SuspendLayout();
            // 
            // localizableUserControl2
            // 
            resources.ApplyResources(this.localizableUserControl2, "localizableUserControl2");
            this.localizableUserControl2.Name = "localizableUserControl2";
            this.localizableUserControl2.NonLocalizableText = "Non localizable.";
            // 
            // localizableUserControl1
            // 
            resources.ApplyResources(this.localizableUserControl1, "localizableUserControl1");
            this.localizableUserControl1.Name = "localizableUserControl1";
            this.localizableUserControl1.NonLocalizableText = "Test";
            // 
            // LocalizedForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.localizableUserControl2);
            this.Controls.Add(this.localizableUserControl1);
            this.Name = "LocalizedForm";
            this.ResumeLayout(false);

		}

		#endregion

		private LocalizableUserControl localizableUserControl1;
        private LocalizableUserControl localizableUserControl2;
	}
}