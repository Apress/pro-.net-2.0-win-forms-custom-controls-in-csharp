namespace DrawingShapes
{
	partial class DrawingSurface
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
			this.components = new System.ComponentModel.Container();
			this.mnuSelectShape = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRemoveShape = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuBringToFront = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSendToBack = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuInsertShape = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuRectangle = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEllipse = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTriangle = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSelectShape.SuspendLayout();
			this.mnuInsertShape.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuSelectShape
			// 
			this.mnuSelectShape.AllowDrop = true;
			this.mnuSelectShape.Enabled = true;
			this.mnuSelectShape.GripMargin = new System.Windows.Forms.Padding(2);
			this.mnuSelectShape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuColor,
            this.mnuRemoveShape,
            this.mnuBringToFront,
            this.mnuSendToBack});
			this.mnuSelectShape.Location = new System.Drawing.Point(25, 66);
			this.mnuSelectShape.Name = "contextMenuStrip1";
			this.mnuSelectShape.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.mnuSelectShape.Size = new System.Drawing.Size(153, 111);
			this.mnuSelectShape.Visible = true;
			// 
			// mnuColor
			// 
			this.mnuColor.Name = "mnuColor";
			this.mnuColor.Text = "Change Color";
			this.mnuColor.Click += new System.EventHandler(this.mnuColorChange_Click);
			// 
			// mnuRemoveShape
			// 
			this.mnuRemoveShape.Name = "mnuRemoveShape";
			this.mnuRemoveShape.Text = "Remove Shape";
			this.mnuRemoveShape.Click += new System.EventHandler(this.mnuRemoveShape_Click);
			// 
			// mnuBringToFront
			// 
			this.mnuBringToFront.Name = "mnuBringToFront";
			this.mnuBringToFront.Text = "Bring to Front";
			this.mnuBringToFront.Click += new System.EventHandler(this.mnuBringToFront_Click);
			// 
			// mnuSendToBack
			// 
			this.mnuSendToBack.Name = "mnuSendToBack";
			this.mnuSendToBack.Text = "Send To Back";
			this.mnuSendToBack.Click += new System.EventHandler(this.mnuSendToBack_Click);
			// 
			// mnuInsertShape
			// 
			this.mnuInsertShape.AllowDrop = true;
			this.mnuInsertShape.Enabled = true;
			this.mnuInsertShape.GripMargin = new System.Windows.Forms.Padding(2);
			this.mnuInsertShape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRectangle,
            this.mnuEllipse,
            this.mnuTriangle});
			this.mnuInsertShape.Location = new System.Drawing.Point(25, 66);
			this.mnuInsertShape.Name = "contextMenuStrip1";
			this.mnuInsertShape.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.mnuInsertShape.Size = new System.Drawing.Size(172, 70);
			// 
			// mnuRectangle
			// 
			this.mnuRectangle.Name = "mnuRectangle";
			this.mnuRectangle.Text = "Create New Rectangle";
			this.mnuRectangle.Click += new System.EventHandler(this.mnuNewShape_Click);
			// 
			// mnuEllipse
			// 
			this.mnuEllipse.Name = "mnuEllipse";
			this.mnuEllipse.Text = "Create New Ellipse";
			this.mnuEllipse.Click += new System.EventHandler(this.mnuNewShape_Click);
			// 
			// mnuTriangle
			// 
			this.mnuTriangle.Name = "mnuTriangle";
			this.mnuTriangle.Text = "Create New Triangle";
			this.mnuTriangle.Click += new System.EventHandler(this.mnuNewShape_Click);
			// 
			// DrawingSurface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 381);
			this.ContextMenuStrip = this.mnuInsertShape;
			this.Name = "DrawingSurface";
			this.Text = "Drawing Shapes";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingSurface_MouseDown);
			this.mnuSelectShape.ResumeLayout(false);
			this.mnuInsertShape.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip mnuSelectShape;
		private System.Windows.Forms.ToolStripMenuItem mnuColor;
		private System.Windows.Forms.ToolStripMenuItem mnuRemoveShape;
		private System.Windows.Forms.ToolStripMenuItem mnuBringToFront;
		private System.Windows.Forms.ToolStripMenuItem mnuSendToBack;
		private System.Windows.Forms.ContextMenuStrip mnuInsertShape;
		private System.Windows.Forms.ToolStripMenuItem mnuRectangle;
		private System.Windows.Forms.ToolStripMenuItem mnuEllipse;
		private System.Windows.Forms.ToolStripMenuItem mnuTriangle;

	}
}

