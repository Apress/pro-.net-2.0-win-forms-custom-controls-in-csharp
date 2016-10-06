using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DrawingControls
{
	public partial class ControlPaintTest : Form
	{
		public ControlPaintTest()
		{
			InitializeComponent();
		}

		private void ControlPaintTest_Paint(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawCheckBox(e.Graphics, new Rectangle(10, 10, 50, 50), ButtonState.Checked);
			ControlPaint.DrawCheckBox(e.Graphics, new Rectangle(70, 10, 30, 30), ButtonState.Normal);
			ControlPaint.DrawCheckBox(e.Graphics, new Rectangle(110, 10, 20, 20), ButtonState.Checked);

			ControlPaint.DrawButton(e.Graphics, new Rectangle(10, 80, 20, 20), ButtonState.Checked);
			ControlPaint.DrawButton(e.Graphics, new Rectangle(50, 80, 20, 20), ButtonState.Flat);
			ControlPaint.DrawButton(e.Graphics, new Rectangle(90, 80, 20, 20), ButtonState.Normal);
			ControlPaint.DrawFocusRectangle(e.Graphics, new Rectangle(130, 80, 20, 20));

			ControlPaint.DrawGrid(e.Graphics, new Rectangle(10, 120, 250, 50), new Size(5, 5), Color.Blue);
			ControlPaint.DrawScrollButton(e.Graphics, new Rectangle(10, 180, 20, 20), ScrollButton.Left, ButtonState.Normal);
			ControlPaint.DrawScrollButton(e.Graphics, new Rectangle(50, 180, 20, 20), ScrollButton.Max, ButtonState.Pushed);
			ControlPaint.DrawScrollButton(e.Graphics, new Rectangle(90, 180, 20, 20), ScrollButton.Up, ButtonState.Normal);

			ControlPaint.DrawMenuGlyph(e.Graphics, new Rectangle(10, 220, 20, 20), MenuGlyph.Arrow);
			ControlPaint.DrawMenuGlyph(e.Graphics, new Rectangle(50, 220, 20, 20), MenuGlyph.Checkmark);
			ControlPaint.DrawMenuGlyph(e.Graphics, new Rectangle(90, 220, 20, 20), MenuGlyph.Max);

		}
	}
}