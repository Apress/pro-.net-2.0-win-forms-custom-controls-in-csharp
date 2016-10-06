using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AnimatedButtons
{
	public class SimpleGlowButton : AnimatedButtonBase
	{
		// Drawing objects.
		private Pen penOutline;
		private StringFormat textFormat;

		public SimpleGlowButton()
		{
			// In a more sophisticated details, these hard-coded
			// details would be mapped to properties.
			penOutline = new Pen(Color.Black, 2);
			penOutline.Alignment = PenAlignment.Inset;

			textFormat = new StringFormat();
			textFormat.Alignment = StringAlignment.Center;
			textFormat.LineAlignment = StringAlignment.Center;
		}
		protected override void PaintNormal(Graphics g)
		{
			g.FillRectangle(Brushes.LightGray, ClientRectangle);
			g.DrawRectangle(penOutline, ClientRectangle);
			g.DrawString(Text, Font, Brushes.Black, ClientRectangle, textFormat);
		}

		protected override void PaintMouseOver(Graphics g)
		{
			g.FillRectangle(Brushes.LimeGreen, ClientRectangle);
			g.DrawRectangle(penOutline, ClientRectangle);
			g.DrawString(Text, Font, Brushes.White, ClientRectangle, textFormat);
		}

		protected override void PaintPushed(Graphics g)
		{
			g.FillRectangle(Brushes.Lime, ClientRectangle);
			g.DrawRectangle(penOutline, ClientRectangle);
			g.DrawString(Text, Font, Brushes.White, ClientRectangle, textFormat);
		}

		protected override void PaintDisabled(Graphics g)
		{
			g.FillRectangle(Brushes.LightSlateGray, ClientRectangle);
			g.DrawRectangle(penOutline, ClientRectangle);
			g.DrawString(Text, Font, Brushes.White, ClientRectangle, textFormat);
		}

		//protected override void Dispose(bool disposing)
		//{
		//    if (disposing)
		//    {
		//        if (penOutline != null) penOutline.Dispose();
		//    }
		//    base.Dispose();
		//}
	}
}
