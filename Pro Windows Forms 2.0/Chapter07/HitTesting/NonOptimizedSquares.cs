using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HitTesting
{
	public partial class NonOptimizedSquares : Form
	{
		public NonOptimizedSquares()
		{
			InitializeComponent();
		}


		// Store the squares that are painted on the form.
		List<Rectangle> squares = new List<Rectangle>();

		private void NonOptimizedSquares_Paint(object sender, PaintEventArgs e)
		{
			Pen pen = new Pen(Color.Red, 10);
			foreach (Rectangle square in squares)
			{
				e.Graphics.DrawRectangle(pen, square);
			}
			pen.Dispose();
			lblCount.Text = " " + squares.Count.ToString() + " squares"; 
		}

		private void NonOptimizedSquares_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				// Add a square and update the screen.
				Rectangle square = new Rectangle(e.X, e.Y, 20, 20);
				squares.Add(square);
                square.Inflate(5, 5);
                Invalidate(square);
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
	}
}