using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.ComponentModel;

namespace AnimatedButtons
{
	public class RolloverButton : AnimatedButtonBase
	{
		private Image normalImage;
		private Image mouseOverImage;
		private Image pushedImage;
		private Image disabledImage;


		public Image NormalImage
		{
			get
			{
				return normalImage;
			}
			set
			{
				normalImage = value;
				if (normalImage != null && DesignMode)
				{
					Size = new Size(normalImage.Size.Width + 10, normalImage.Size.Height + 2);
					BackColor = Color.Transparent;
				}
				Invalidate();
			}
		}

		public Image MouseOverImage
		{
			get
			{
				return mouseOverImage;
			}
			set
			{
				mouseOverImage = value;
				Invalidate();
			}
		}

		public Image PushedImage
		{
			get
			{
				return pushedImage;
			}
			set
			{
				pushedImage = value;
				Invalidate();
			}
		}

		public Image DisabledImage
		{
			get
			{
				return disabledImage;
			}
			set
			{
				disabledImage = value;
				Invalidate();
			}
		}
		protected override void PaintNormal(Graphics g)
		{
			if (normalImage != null)
				g.DrawImageUnscaled(normalImage, new Point(0,0));
		}

		protected override void PaintMouseOver(Graphics g)
		{
			if (mouseOverImage != null)
			{
                g.DrawImageUnscaled(mouseOverImage, new Point(0, 0));
			}
			else if (normalImage != null)
			{
				// If there is no mouse-over image, fall back on the
				// normal image (if it exists).
                g.DrawImageUnscaled(normalImage, new Point(0, 0));
			}
		}

		protected override void PaintPushed(Graphics g)
		{
			// Try pushed, mouse over, and normal images, in 
			// that order of preference.
			if (pushedImage != null)
			{
                g.DrawImageUnscaled(pushedImage, new Point(0, 0));
			}
			else if (mouseOverImage != null)
			{
                g.DrawImageUnscaled(mouseOverImage, new Point(0, 0));
			}
			else if (normalImage != null)
			{
                g.DrawImageUnscaled(normalImage, new Point(0, 0));
			}
		}

		protected override void PaintDisabled(Graphics g)
		{
			if (disabledImage != null)
			{
                g.DrawImageUnscaled(disabledImage, new Point(0, 0));
			}
			else
			{
				if (normalImage != null)
				{
					// Fake a disabled image.
					// Serveral techniques are possible, but this is the easiest.
					ControlPaint.DrawImageDisabled(g, normalImage, 0, 0, BackColor);
				}
			}
		}

        protected override bool HitTest(int X, int Y)
        {
            if (normalImage == null) return false;

            return ((X < normalImage.Width + 10) && (Y < normalImage.Height + 2));
        }
	}
}
