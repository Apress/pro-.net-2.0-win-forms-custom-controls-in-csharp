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
	public partial class SimpleShapedForm : Form
	{
		public SimpleShapedForm()
		{
			InitializeComponent();
		}

		private void SimpleShapedForm_Load(object sender, EventArgs e)
		{
			GraphicsPath path = new GraphicsPath();
			path.AddEllipse(0, 0, this.Width, this.Height);
			this.Region = new Region(path);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}