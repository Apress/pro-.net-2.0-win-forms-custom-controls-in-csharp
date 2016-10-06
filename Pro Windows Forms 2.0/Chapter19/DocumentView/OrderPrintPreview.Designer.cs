namespace DocumentView
{
	partial class OrderPrintPreview
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
			this.Preview = new System.Windows.Forms.PrintPreviewControl();
			this.SuspendLayout();
			// 
			// Preview
			// 
			this.Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.Preview.AutoZoom = false;
			this.Preview.Location = new System.Drawing.Point(4, 4);
			this.Preview.Name = "Preview";
			this.Preview.Size = new System.Drawing.Size(401, 204);
			this.Preview.TabIndex = 2;
			this.Preview.Zoom = 1;
			// 
			// OrderPrintPreview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Preview);
			this.Name = "OrderPrintPreview";
			this.Size = new System.Drawing.Size(408, 212);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PrintPreviewControl Preview;
	}
}
