using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SimpleDrawing
{
	public partial class FlawedResizing : Form
	{
		public FlawedResizing()
		{
			InitializeComponent();
		}

		private void FlawedResizing_Paint(object sender, PaintEventArgs e)
		{
            ResizeRedraw = chkResizeRedraw.Checked;
            Pen pen = new Pen(Color.Red, 1);
            e.Graphics.DrawEllipse(pen, new Rectangle(new Point(0, 0),
              this.ClientSize));
            pen.Dispose();        
            
		}

		private void chkResizeRedraw_CheckedChanged(object sender, EventArgs e)
		{
			Invalidate();
		}
	}
}