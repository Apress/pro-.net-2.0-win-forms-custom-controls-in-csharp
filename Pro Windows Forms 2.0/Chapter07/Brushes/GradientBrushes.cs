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
	public partial class GradientBrushes : Form
	{
		public GradientBrushes()
		{
			InitializeComponent();
		}

		private void GradientBrushes_Paint(object sender, PaintEventArgs e)
		{
			LinearGradientBrush myBrush;
			int y = 20;
			int x = 20;

			foreach (LinearGradientMode gradientStyle in System.Enum.GetValues(typeof(LinearGradientMode)))
			{
				myBrush = new LinearGradientBrush(new Rectangle(x, y, 100, 60), Color.Violet, Color.White, gradientStyle);
				e.Graphics.FillRectangle(myBrush, x, y, 100, 60);
				e.Graphics.DrawString(gradientStyle.ToString(), new Font("Tahoma", 8), Brushes.Black, 110 + x, y + 20);
				y += 70;
			}
		}
	}
}