using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SimpleDrawing
{
	public partial class Smoothing : Form
	{
		public Smoothing()
		{
			InitializeComponent();
		}

		private void picNone_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawEllipse(e.Graphics);
		}

		private void picHighSpeed_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.HighSpeed;
			DrawEllipse(e.Graphics);

		}

		private void picAntialias_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			DrawEllipse(e.Graphics);
		}

		private void picHighQuality_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			DrawEllipse(e.Graphics);
		}

		private void DrawEllipse(Graphics g)
		{
			Pen drawingPen = new Pen(Color.Red, 5);
			g.DrawEllipse(drawingPen, 10, 10, 300, 40);
		}

	}
}