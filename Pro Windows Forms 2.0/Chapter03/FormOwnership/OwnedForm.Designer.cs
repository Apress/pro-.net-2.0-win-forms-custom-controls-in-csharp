namespace FormOwnership
{
	partial class OwnedForm
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
			this.lblState = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblState
			// 
			this.lblState.Location = new System.Drawing.Point(26, 24);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(184, 56);
			this.lblState.TabIndex = 2;
			// 
			// OwnedForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(236, 104);
			this.Controls.Add(this.lblState);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "OwnedForm";
			this.Text = "OwnedForm";
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Label lblState;

	}
}