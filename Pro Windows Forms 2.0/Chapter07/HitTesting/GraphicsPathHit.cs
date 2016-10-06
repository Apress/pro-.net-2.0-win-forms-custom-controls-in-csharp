using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace HitTesting
{
	public partial class GraphicsPathHit : Form
	{
		public GraphicsPathHit()
		{
			InitializeComponent();
		}

		GraphicsPath path;

		private void GraphicsPathHit_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			path = new GraphicsPath();
			path.StartFigure();
			path.AddArc(10, 10, 100, 100, 20, 50);
			path.AddLine(20, 50, 70, 230);
			path.CloseFigure();
			path.AddEllipse(120, 50, 80, 80);
			e.Graphics.FillPath(Brushes.White, path);
			e.Graphics.DrawPath(Pens.Black, path);
		}

		private void GraphicsPathHit_MouseDown(object sender, MouseEventArgs e)
		{
			if (path.IsVisible(e.X, e.Y))
			{
				MessageBox.Show("You clicked inside the figure.");
			}
		}
	}
}