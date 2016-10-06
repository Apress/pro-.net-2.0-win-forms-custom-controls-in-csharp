using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace SimpleDrawing
{
	public partial class SmoothingText : Form
	{
		public SmoothingText()
		{
			InitializeComponent();
		}

		private void SmoothingText_Paint(object sender, PaintEventArgs e)
		{
			Font TextFont = new Font("Times New Roman", 25, FontStyle.Italic);
			e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
			e.Graphics.DrawString("Sample Text", TextFont, Brushes.Black, 20, 20);
			e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
			e.Graphics.DrawString("Sample Text", TextFont, Brushes.Black, 20, 85);
			e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			e.Graphics.DrawString("Sample Text", TextFont, Brushes.Black, 20, 150);

		}
	}
}