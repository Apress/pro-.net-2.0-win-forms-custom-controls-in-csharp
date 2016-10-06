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
	public partial class PenDashStyles : Form
	{
		public PenDashStyles()
		{
			InitializeComponent();
		}

		private void PenDashStyles_Paint(object sender, PaintEventArgs e)
		{
			Pen myPen = new Pen(Color.Blue, 10);
			int y = 20;
			foreach (DashStyle dash in Enum.GetValues(typeof(DashStyle)))
			{
				myPen.DashStyle = dash;
				e.Graphics.DrawLine(myPen, 20, y, 100, y);
				e.Graphics.DrawString(dash.ToString(), new Font("Tahoma", 8), Brushes.Black, 120, y - 10);
				y += 30;
			}

			y += 10;
			myPen.StartCap = LineCap.Round;
			myPen.EndCap = LineCap.Round;

			foreach (DashStyle dash in System.Enum.GetValues(typeof(DashStyle)))
			{
				myPen.DashStyle = dash;
				e.Graphics.DrawLine(myPen, 20, y, 100, y);
				e.Graphics.DrawString(dash.ToString() + " (with round caps)", new Font("Tahoma", 8), Brushes.Black, 120, y - 10);
				y += 30;
			}
		}

		private void PenDashStyles_Resize(object sender, EventArgs e)
		{

		}
	}
}