using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AuthenticDragAndDrop
{
	public partial class DrawingArea : Form
	{
		public DrawingArea()
		{
			InitializeComponent();
		}

		private void DrawingArea_Load(object sender, EventArgs e)
		{
			Palette frmTool = new Palette();
			this.AddOwnedForm(frmTool);
			frmTool.Show();
			picDrawingArea.AllowDrop = true;
		}

		private void picDrawingArea_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Bitmap))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void picDrawingArea_DragDrop(object sender, DragEventArgs e)
		{
			Graphics g = picDrawingArea.CreateGraphics();
			g.DrawImage((Image)e.Data.GetData(DataFormats.Bitmap),
				new Point(e.X - this.Left - 12, e.Y - this.Top - 30));

		}
	}
}