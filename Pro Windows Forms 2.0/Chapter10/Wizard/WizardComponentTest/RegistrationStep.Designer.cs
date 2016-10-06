namespace WizardComponentTest
{
    partial class RegistrationStep
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
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
			this.optRegisterToday = new System.Windows.Forms.RadioButton();
			this.optLater = new System.Windows.Forms.RadioButton();
			this.optNever = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// optRegisterToday
			// 
			this.optRegisterToday.AutoSize = true;
			this.optRegisterToday.Location = new System.Drawing.Point(12, 11);
			this.optRegisterToday.Name = "optRegisterToday";
			this.optRegisterToday.Size = new System.Drawing.Size(179, 17);
			this.optRegisterToday.TabIndex = 0;
			this.optRegisterToday.TabStop = false;
			this.optRegisterToday.Text = "Register today (discount applies)";
			// 
			// optLater
			// 
			this.optLater.AutoSize = true;
			this.optLater.Location = new System.Drawing.Point(12, 31);
			this.optLater.Name = "optLater";
			this.optLater.Size = new System.Drawing.Size(98, 17);
			this.optLater.TabIndex = 1;
			this.optLater.TabStop = false;
			this.optLater.Text = "Remind me later";
			// 
			// optNever
			// 
			this.optNever.AutoSize = true;
			this.optNever.Location = new System.Drawing.Point(12, 51);
			this.optNever.Name = "optNever";
			this.optNever.Size = new System.Drawing.Size(105, 17);
			this.optNever.TabIndex = 2;
			this.optNever.TabStop = false;
			this.optNever.Text = "Stop nagging me!";
			// 
			// RegistrationStep
			// 
			this.Controls.Add(this.optNever);
			this.Controls.Add(this.optLater);
			this.Controls.Add(this.optRegisterToday);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "RegistrationStep";
			this.Size = new System.Drawing.Size(214, 83);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.RadioButton optRegisterToday;
		private System.Windows.Forms.RadioButton optLater;
		private System.Windows.Forms.RadioButton optNever;

	}
}
