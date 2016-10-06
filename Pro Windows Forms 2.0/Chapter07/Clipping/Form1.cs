using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Clipping
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			// Clip to path (with shape).
			Rectangle rectangle = new Rectangle(10, 10, 250, 50);
			GraphicsPath path = new GraphicsPath();
			path.AddEllipse(rectangle);
			e.Graphics.DrawPath(Pens.Red, path);
			
			// Set the clipping.
			Region clippingRegion = new Region(path);
			if (chkClipping.Checked) e.Graphics.Clip = clippingRegion;

			// Draw in the clipped region.
			e.Graphics.DrawString("Clipped", 
				new Font("Verdana", 36, FontStyle.Bold), Brushes.Black, 10, 10);

			clippingRegion.Dispose();
			path.Dispose();

			// Rest the clipping region.
			e.Graphics.ResetClip();
			
			// Clip to path (which represents text).
			path = new GraphicsPath();
			path.AddString("Clipped", new FontFamily("Verdana"), 0, 70, new Point(10, 130), new StringFormat());
			e.Graphics.DrawPath(Pens.Blue, path);

			// Set the clipping.
			clippingRegion = new Region(path);
			if (chkClipping.Checked) e.Graphics.Clip = clippingRegion;

			// Draw a series of ellipsis in the clipped region.
			for (int i = 0; i < 40; i++)
			{
				e.Graphics.DrawEllipse(Pens.Red, 180 - i*3, 180 - i*3, i*6, i*6);			
			}
			clippingRegion.Dispose();
			path.Dispose();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			Invalidate();
		}
	}
}