using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Transforms
{
	public partial class TranslateTransform : Form
	{
		public TranslateTransform()
		{
			InitializeComponent();
		}

		private void TranslateTransform_Paint(object sender, PaintEventArgs e)
		{
			// Draw several squares in different places.
			DrawRectangle(e.Graphics);
			e.Graphics.TranslateTransform(180, 60);
			DrawRectangle(e.Graphics);
			e.Graphics.TranslateTransform(-50, 80);
			DrawRectangle(e.Graphics);
			e.Graphics.TranslateTransform(-100, 50);
			DrawRectangle(e.Graphics);
		}

		private void DrawRectangle(Graphics g)
		{
			Pen drawingPen = new Pen(Color.Red, 30);

			// Draw a rectangle at a fixed position.
			g.DrawRectangle(drawingPen, new Rectangle(20, 20, 20, 20));
		}
	}
}