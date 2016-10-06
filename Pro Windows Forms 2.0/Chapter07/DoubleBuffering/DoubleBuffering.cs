using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoubleBuffering
{
	public partial class DoubleBuffering : Form
	{
		public DoubleBuffering()
		{
			InitializeComponent();
		}

		private bool isShrinking = false;
		private int extraSize = 0;

		// This code is triggered in response to the timer tick.
		private void tmrRefresh_Tick(object sender,
		 System.EventArgs e)
		{
			// Change the circle dimensions.
			if (isShrinking)
				extraSize--;
			else
				extraSize++;

			// Change the sizing direction if needed.
			if (extraSize > (this.Width - 150))
				isShrinking = true;
			else if (extraSize < 1)
				isShrinking = false;

			// Repaint the form.
			this.Invalidate();
		}

		private void DoubleBuffering_Paint(object sender,
 System.Windows.Forms.PaintEventArgs e)
		{
			// Check if double buffering is needed.
			this.DoubleBuffered = chkDoubleBuffer.Checked;

			Graphics g = e.Graphics;
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

			// Draw a rectangle.
			Pen drawingPen = new Pen(Color.Black, 10);
			g.FillRectangle(Brushes.White, new Rectangle(new Point(0, 0),
							this.ClientSize));
			g.DrawEllipse(drawingPen, 50, 50, 50 + extraSize, 50 + extraSize);
		}

		private void DoubleBuffering_Load(object sender, EventArgs e)
		{
			tmrRefresh.Start();
		}
	}
}