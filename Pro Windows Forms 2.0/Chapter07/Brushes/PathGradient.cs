using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Brush
{
	public partial class PathGradient : Form
	{
		public PathGradient()
		{
			InitializeComponent();
		}

		private void PathGradient_Paint(object sender, PaintEventArgs e)
		{
			GraphicsPath path = new GraphicsPath();
			int size = 150;
			path.AddEllipse(10, 10, size, size);
			
			PathGradientBrush brush = new PathGradientBrush(path);
			brush.WrapMode = WrapMode.Tile;
			brush.SurroundColors = new Color[] { Color.White };
			brush.CenterColor = Color.Violet;
			e.Graphics.FillRectangle(brush, 10, 10, size, size);
			
			path.Dispose();
			brush.Dispose();
        
        
		}
	}
}