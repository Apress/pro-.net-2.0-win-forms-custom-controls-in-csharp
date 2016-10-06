using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Pens
{
	public partial class PenAlignments : Form
	{
		public PenAlignments()
		{
			InitializeComponent();
		}

		private void PenAlignment_Load(object sender, EventArgs e)
		{

		}

		private void PenAlignment_Paint(object sender, PaintEventArgs e)
		{
			// Example of border problem.
			//Rectangle rect = new Rectangle(10, 10, 110, 110);
			//Pen pen = new Pen(Color.Red, 1);
			//Brush brush = Brushes.LightBlue;
			//e.Graphics.DrawRectangle(pen, rect);
			//e.Graphics.FillRectangle(brush, rect);

			
			Rectangle rect = new Rectangle(10, 10, 110, 110);
			Pen pen = new Pen(Color.White, 11);
			Pen penOutline = new Pen(Color.Black, 1);
			penOutline.Alignment = PenAlignment.Inset;
			pen.Alignment = PenAlignment.Center;
			e.Graphics.DrawString("11-Pixel Centered Pen", SystemFonts.DefaultFont, Brushes.Black, rect.Location);
			rect.Offset(0, 25);
			e.Graphics.FillRectangle(Brushes.LightBlue, rect);
			e.Graphics.DrawRectangle(pen, rect);
			e.Graphics.DrawRectangle(penOutline, rect);
			
			rect.Offset(150, -25);
			e.Graphics.DrawString("11-Pixel Inset Pen", SystemFonts.DefaultFont, Brushes.Black, rect.Location);
			rect.Offset(0, 25);
			pen.Alignment = PenAlignment.Inset;
			e.Graphics.FillRectangle(Brushes.LightBlue, rect);
			e.Graphics.DrawRectangle(pen, rect);
			e.Graphics.DrawRectangle(penOutline, rect);
			
			
			pen.Dispose();
		}
	}
}