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
	public partial class PenCaps : Form
	{
		public PenCaps()
		{
			InitializeComponent();
		}

		private void PenCap_Paint(object sender, PaintEventArgs e)
		{
			Pen myPen = new Pen(Color.Blue, 10);
			int y = 20;

			foreach (LineCap cap in Enum.GetValues(typeof(LineCap)))
			{
				myPen.StartCap = cap;
				myPen.EndCap = cap;
				e.Graphics.DrawLine(myPen, 20, y, 100, y);
				e.Graphics.DrawString(cap.ToString(), new Font("Tahoma", 8), Brushes.Black, 120, y - 10);
				y += 30;
			}
		}
	}
}