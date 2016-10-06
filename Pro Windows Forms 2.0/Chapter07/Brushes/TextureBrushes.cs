using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Brush
{
	public partial class TextureBrushes : Form
	{
		public TextureBrushes()
		{
			InitializeComponent();
		}

		private void TextureBrushes_Paint(object sender, PaintEventArgs e)
		{
			TextureBrush myBrush = new TextureBrush(Properties.Resources.tile);
			e.Graphics.FillRectangle(myBrush, e.Graphics.ClipBounds);
		}
	}
}