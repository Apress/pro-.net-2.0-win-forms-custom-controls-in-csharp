namespace BindingToDataSet
{
	partial class SimpleListBinding
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
            this.lstModelName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstModelName
            // 
            this.lstModelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstModelName.FormattingEnabled = true;
            this.lstModelName.Location = new System.Drawing.Point(10, 12);
            this.lstModelName.Name = "lstModelName";
            this.lstModelName.Size = new System.Drawing.Size(268, 238);
            this.lstModelName.TabIndex = 0;
            // 
            // SimpleListBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.lstModelName);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SimpleListBinding";
            this.Text = "List Binding";
            this.Load += new System.EventHandler(this.SimpleListBinding_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstModelName;
	}
}

