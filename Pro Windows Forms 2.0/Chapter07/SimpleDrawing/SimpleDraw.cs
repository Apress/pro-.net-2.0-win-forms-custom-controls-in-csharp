using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleDrawing
{
	public partial class SimpleDraw : Form
	{
		public SimpleDraw()
		{
			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			if (chkRepaint.Checked)
			{
				Pen drawingPen = new Pen(Color.Red, 15);
				e.Graphics.DrawArc(drawingPen, 50, 20, 100, 200, 40, 210);
				drawingPen.Dispose();
			}
		}
	}
}