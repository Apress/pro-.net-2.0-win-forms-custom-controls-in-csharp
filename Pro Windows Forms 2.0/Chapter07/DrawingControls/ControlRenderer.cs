using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DrawingControls
{
	public partial class ControlRenderer : Form
	{
		public ControlRenderer()
		{
			InitializeComponent();
		}

		private void ControlRenderer_Paint(object sender, PaintEventArgs e)
		{
			
				CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(10,10),
					new Rectangle(10,10,110,15), "Style checkbox", Font,false, CheckBoxState.CheckedNormal);
			
		}
	}
}