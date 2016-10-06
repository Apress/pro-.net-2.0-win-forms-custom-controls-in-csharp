using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace AlphaBlending
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			// Fill the background with a tile.
			Bitmap bitmap = Properties.Resources.Pic;
			TextureBrush brush = new TextureBrush(bitmap);
			e.Graphics.FillRectangle(brush, ClientRectangle);
            bitmap.Dispose();

			// Draw some solid content.
			Color color = Color.Yellow;
			int penWidth = 80;
			Pen opaquePen = new Pen(color, penWidth);
			e.Graphics.DrawLine(opaquePen, 0, 50, 200, 20);
            opaquePen.Dispose();

			// Make the color partly transparent (50%).
			Color semiTransparentColor = Color.FromArgb(128, color.R, color.G, color.B);
			Pen semiTransparentPen = new Pen(semiTransparentColor, penWidth);
			e.Graphics.DrawLine(semiTransparentPen, 0, 200, 200, 140);
            semiTransparentPen.Dispose();

			// Make the color very transparent (70%).
			Color veryTransparentColor = Color.FromArgb(77, color.R, color.G, color.B);
			Pen veryTransparentPen = new Pen(veryTransparentColor, penWidth);
			e.Graphics.DrawLine(veryTransparentPen, 0, 350, 200, 260);
            veryTransparentPen.Dispose();
		
			// Draw some transparent text.
			Brush transparentBrush = new SolidBrush(semiTransparentColor);
			e.Graphics.DrawString("TRANSPARENT", new Font("Verdana", 36, FontStyle.Bold),
				transparentBrush, 80, 150);
		}
	}
}