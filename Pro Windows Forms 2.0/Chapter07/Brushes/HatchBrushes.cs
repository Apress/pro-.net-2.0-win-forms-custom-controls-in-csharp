using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Brush
{
	public partial class HatchBrushes : Form
	{
		public HatchBrushes()
		{
			InitializeComponent();
		}

		private void HatchBrushes_Paint(object sender, PaintEventArgs e)
		{
			
			int y = 20;
			int x = 20;

            Font font = new Font("Tahoma", 8);
			// Enumerate over all the styles.
			foreach (HatchStyle brushStyle in System.Enum.GetValues(typeof(HatchStyle)))
			{
				HatchBrush myBrush = new HatchBrush(brushStyle, Color.Blue, Color.LightYellow);

				// Fill a rectangle with the brush.
				e.Graphics.FillRectangle(myBrush, x, y, 40, 20);

				// Display the brush name.
				e.Graphics.DrawString(brushStyle.ToString(), font,
					Brushes.Black, 50 + x, y + 5);

				y += 30;
				if ((y + 30) > this.ClientSize.Height)
				{
					y = 20;
					x += 180;
				}
                myBrush.Dispose();
			}
            font.Dispose();
		}
	}
}