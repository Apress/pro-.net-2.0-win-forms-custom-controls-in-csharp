using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FakeDragAndDrop
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Label lblDragger;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.lblDragger = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblDragger
			// 
			this.lblDragger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDragger.Image = ((System.Drawing.Bitmap)(resources.GetObject("lblDragger.Image")));
			this.lblDragger.Location = new System.Drawing.Point(110, 105);
			this.lblDragger.Name = "lblDragger";
			this.lblDragger.Size = new System.Drawing.Size(72, 56);
			this.lblDragger.TabIndex = 2;
			this.lblDragger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblDragger_MouseUp);
			this.lblDragger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblDragger_MouseMove);
			this.lblDragger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDragger_MouseDown);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lblDragger});
			this.Name = "Form1";
			this.Text = "Fake Drag And Drop";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		// Keep track of when fake "drag and drop" mode is enabled.
		private bool isDragging = false;

		// Store the location where the user clicked the control.
		private int clickOffsetX, clickOffsetY;

		// Start dragging.
		private void lblDragger_MouseDown(System.Object sender,
			System.Windows.Forms.MouseEventArgs e)
		{
			isDragging = true;
			clickOffsetX = e.X;
			clickOffsetY = e.Y;
		}

		// End dragging.
		private void lblDragger_MouseUp(System.Object sender,
			System.Windows.Forms.MouseEventArgs e)
		{
			isDragging = false;
		}

		// Move the control (during dragging).
		private void lblDragger_MouseMove(System.Object sender,
			System.Windows.Forms.MouseEventArgs e)
		{
			if (isDragging == true)
			{
				// The control coordinates are converted into form coordinates
				// by adding the label position offset.
				// The offset where the user clicked in the control is also
				// accounted for. Otherwise, it looks like the top-left corner
				// of the label is attached to the mouse.
				lblDragger.Left = e.X + lblDragger.Left - clickOffsetX;
				lblDragger.Top = e.Y + lblDragger.Top - clickOffsetY;
			}
		}

	}
}
