using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace AnimatedButtons
{
	public class PopImageButton : AnimatedButtonBase
	{
		private Image image;
		private Rectangle bounds;

		public Image Image
		{
			get
			{
				return image;
			}
			set
			{
				image = value;
				if (image != null)
				{
					bounds = new Rectangle(0, 0, image.Width + 5, image.Height + 5);
				}
				Invalidate();
			}
		}

		protected override bool HitTest(int X, int Y)
		{
			// Check if the mouse pointer is over the button.
			// If the mouse moves off the button surface, it will be deactivated,
			// even if the button is being held in a pressed position.
			// The code repaints the button only if needed.
			if (image == null)
				return false;
			else
				return bounds.Contains(X, Y);
		}


		protected override void PaintNormal(Graphics g)
		{
			if (image != null) g.DrawImage(image, 2, 2);
			PaintText(g);
		}

		protected override void PaintMouseOver(Graphics g)
		{
			if (image != null)
			{
				ControlPaint.DrawBorder3D(g, bounds,
					Border3DStyle.Raised, Border3DSide.All);
				g.DrawImage(image, 2, 2);
			}
			PaintText(g);
		}

		protected override void PaintPushed(Graphics g)
		{
			if (image != null)
			{
				ControlPaint.DrawBorder3D(g, bounds,
					Border3DStyle.Sunken, Border3DSide.All);
				g.DrawImage(image, 3, 3);
			}
			PaintText(g);
		}

		protected override void PaintDisabled(Graphics g)
		{
			if (image != null)
			{
				ControlPaint.DrawImageDisabled(g, image, 2, 2,
				  BackColor);
			}
			PaintText(g);
		}


		private void PaintText(Graphics g)
		{
			int y = 0;
			if (image == null)
				y = Height;
			else
				y = bounds.Height;

			SolidBrush brush = new SolidBrush(ForeColor);
			g.DrawString(Text, Font,
			  brush, bounds.Width + 3, (y - Font.Height) / 2);
			brush.Dispose();
		}

	}

}
