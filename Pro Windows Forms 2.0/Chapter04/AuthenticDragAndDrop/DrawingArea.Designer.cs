namespace AuthenticDragAndDrop
{
	partial class DrawingArea
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
			this.picDrawingArea = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picDrawingArea)).BeginInit();
			this.SuspendLayout();
			// 
			// picDrawingArea
			// 
			this.picDrawingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.picDrawingArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picDrawingArea.Location = new System.Drawing.Point(1, 2);
			this.picDrawingArea.Name = "picDrawingArea";
			this.picDrawingArea.Size = new System.Drawing.Size(377, 270);
			this.picDrawingArea.TabIndex = 2;
			this.picDrawingArea.TabStop = false;
			this.picDrawingArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.picDrawingArea_DragDrop);
			this.picDrawingArea.DragEnter += new System.Windows.Forms.DragEventHandler(this.picDrawingArea_DragEnter);
			// 
			// DrawingArea
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 274);
			this.Controls.Add(this.picDrawingArea);
			this.Name = "DrawingArea";
			this.Text = "Drawing Area";
			this.Load += new System.EventHandler(this.DrawingArea_Load);
			((System.ComponentModel.ISupportInitialize)(this.picDrawingArea)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picDrawingArea;
	}
}

