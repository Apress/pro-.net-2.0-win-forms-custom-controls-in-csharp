using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ShapedForms
{
	public partial class CompoundShapedForm : Form
	{
		public CompoundShapedForm()
		{
			InitializeComponent();
		}

		private GraphicsPath path = new GraphicsPath();

		private void CompoundShapedForm_Load(object sender, EventArgs e)
		{

			path.AddEllipse(0, 0, this.Width / 2, this.Height / 2);
			path.AddRectangle(new Rectangle(this.Width / 2, this.Height / 4,
				this.Width / 2, this.Height / 4));
			path.AddEllipse(this.Width / 2, this.Height / 2, this.Width / 2,
				this.Height / 2);
			this.Region = new Region(path);

		}

		private void CompoundShapedForm_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			e.Graphics.FillPath(Brushes.LightBlue, path);
			Pen pen = new Pen(Color.SlateBlue, 8);
			e.Graphics.DrawPath(pen, path);
			pen.Dispose();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}