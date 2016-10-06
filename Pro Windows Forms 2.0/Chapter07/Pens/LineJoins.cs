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
	public partial class LineJoins : Form
	{
		public LineJoins()
		{
			InitializeComponent();
		}

		private void LineJoins_Load(object sender, EventArgs e)
		{
			
		}

		private void LineJoins_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

			Pen myPen = new Pen(Color.Blue, 10);
			int y = 20;

			foreach (LineJoin join in Enum.GetValues(typeof(LineJoin)))
			{
				myPen.LineJoin = join;
				e.Graphics.DrawRectangle(myPen, 20, y, 70, 40);
				e.Graphics.DrawString(join.ToString(), new Font("Tahoma", 8), Brushes.Black, 100, y + 10);
				y += 70;
			}
		}
	}
}