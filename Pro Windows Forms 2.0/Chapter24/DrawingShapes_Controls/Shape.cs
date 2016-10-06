using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace DrawingShapes
{
	public class Shape : System.Windows.Forms.Control
	{
		// The types of shapes supported by this control.
		public enum ShapeType
		{
			Rectangle, Ellipse, Triangle
		}

		// The current shape.
		private ShapeType shape = ShapeType.Rectangle;
		private GraphicsPath path = null;
		public ShapeType Type
		{
			get { return shape; }
			set
			{
				shape = value;
				RefreshPath();
				this.Invalidate();
			}
		}

		// Create the corresponding GraphicsPath for the shape, and apply
		// it to the control by setting the Region property.
		private void RefreshPath()
		{
			if (path != null) path.Dispose();
			path = new GraphicsPath();
			switch (shape)
			{
				case ShapeType.Rectangle:
					path.AddRectangle(this.ClientRectangle);
					break;
				case ShapeType.Ellipse:
					path.AddEllipse(this.ClientRectangle);
					break;
				case ShapeType.Triangle:
					Point pt1 = new Point(this.Width / 2, 0);
					Point pt2 = new Point(0, this.Height);
					Point pt3 = new Point(this.Width, this.Height);
					path.AddPolygon(new Point[] { pt1, pt2, pt3 });
					break;
			}
			this.Region = new Region(path);
		}


		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			base.OnPaint(e);
			if (path != null)
			{
				SolidBrush shapeBrush = new SolidBrush(this.BackColor);
				Pen shapePen = new Pen(this.ForeColor, 4);

				e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				e.Graphics.FillPath(shapeBrush, path);
				e.Graphics.DrawPath(shapePen, path);

				shapePen.Dispose();
				shapeBrush.Dispose();
			}
		}

		protected override void OnResize(System.EventArgs e)
		{
			base.OnResize(e);
			RefreshPath();
			this.Invalidate();
		}
	}

}
