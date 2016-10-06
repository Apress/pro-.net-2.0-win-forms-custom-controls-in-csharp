using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Transforms
{
	public partial class RotateTransform : Form
	{
		public RotateTransform()
		{
			InitializeComponent();
		}

		private void RotateTransform_Paint(object sender, PaintEventArgs e)
		{
			// Optimize text quality.
			e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

			// Move origin to center of form so we can rotate around that.
			e.Graphics.TranslateTransform(this.Width / 2 - 30, this.Height / 2 - 30);

			DrawText(e.Graphics);
			e.Graphics.RotateTransform(45);
			DrawText(e.Graphics);
			e.Graphics.RotateTransform(75);
			DrawText(e.Graphics);
			e.Graphics.RotateTransform(160);
			DrawText(e.Graphics);
		}

		private void DrawText(Graphics g)
		{
			g.DrawString("Text", new Font("Verdana", 30, FontStyle.Bold),
				Brushes.Black, 0, 0); 
		}
	}
}