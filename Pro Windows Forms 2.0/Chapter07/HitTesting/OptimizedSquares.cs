using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HitTesting
{
	public partial class OptimizedSquares : Form
	{
		public OptimizedSquares()
		{
			InitializeComponent();
		}

		// Store the squares that are painted on the form.
		List<Rectangle> squares = new List<Rectangle>();


		// Paint a square in response to a mouse click.
		private void DrawSquare_MouseDown(object sender,
		 System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Rectangle square = new Rectangle(e.X, e.Y, 20, 20);
				squares.Add(square);

				Graphics g = this.CreateGraphics();
				DrawRectangle(square, g);
				g.Dispose();
			}
			else if (e.Button == MouseButtons.Right)
			{
				// Search  for the clicked square.
				int squareNumber = 0;
				foreach (Rectangle square in squares)
				{
					squareNumber++;
					if (square.Contains(e.X, e.Y))
					{
						MessageBox.Show("Point inside square #" +
						  squareNumber.ToString());
					}
				}
			}
			
		}

		// Paint all the squares when the form needs to be refreshed
		// in response to the Paint event.
		private void DrawSquare_Paint(object sender,
		 System.Windows.Forms.PaintEventArgs e)
		{
			foreach (Rectangle square in squares)
			{
				DrawRectangle(square, e.Graphics);
			}
			
		}

		// This procedure performs the actual drawing, and is called by
		// DrawSquare_MouseDown and DrawSquare_Paint.
		private void DrawRectangle(Rectangle rect, Graphics g)
		{
			Pen pen = new Pen(Color.Red, 10);
			g.DrawRectangle(pen, rect);
			pen.Dispose();
			lblCount.Text = " " + squares.Count.ToString() + " squares";
		}

	}
}