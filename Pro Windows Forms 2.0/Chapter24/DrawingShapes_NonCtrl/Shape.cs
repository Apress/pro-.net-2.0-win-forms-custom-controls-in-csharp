using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DrawingShapes
{
	[Serializable]
	public abstract class Shape : IComparable
	{
		// Support sorting based on z-order. This makes it easy
		// to paint groups of Shape controls in the right order.
		public int CompareTo(object shape)
		{
			return ZOrder.CompareTo(((Shape)shape).ZOrder);
		}

		// Even internally, all access to the path should
		// go through the Path property, so that the path
		// is regenerated if null.
		[NonSerialized]
		private GraphicsPath path = null;
		public GraphicsPath Path
		{
			get
			{
				// The path is refreshed automatically
				// as needed.
				if (path == null)
				{
					RefreshPath();
				}
				return path;
			}
		}

		// Create the corresponding GraphicsPath for the shape.
		private void RefreshPath()
		{
			path = GeneratePath();
		}

		protected abstract GraphicsPath GeneratePath();

		[NonSerialized]
		private Region region;
		public Region Region
		{
			get
			{
				if (region == null)
				{
					region = new Region(Path);
				}
				return region;
			}
		}

		// This is useful when refreshing the form.
		// It takes into account the region occupied by the
		// border and focus rectangle.
		public virtual Rectangle GetLargestPossibleRegion()
		{
			Rectangle rect = Rectangle.Round(Path.GetBounds());
			rect.Inflate(new Size(focusBorderSpace, focusBorderSpace));
			return rect;
			//return new Region(rect);
		}

		// Check if the point is in the shape.
		public virtual bool HitTest(Point point)
		{
			//  if (rotation != 0)
			//matrix.RotateAt(rotation, new PointF(location.X, location.Y), 
			//  Drawing.Drawing2D.MatrixOrder.Append)
			//path.Transform(matrix)         
			return Path.IsVisible(point);
		}

		// Check if the point is in the outline of the shape.
		public virtual bool HitTestBorder(Point point)
		{
			if (outlinePen == null)
			{
				return false;
			}
			else
			{
				return Path.IsOutlineVisible(point, outlinePen);
			}
		}

		public enum HitSpot
		{
			Top, Bottom, Left, Right,
			TopLeftCorner, BottomLeftCorner,
			TopRightCorner, BottomRightCorner,
			None
		}

		public bool HitTestFocusBorder(Point point, out HitSpot hitSpot)
		{
			hitSpot = HitSpot.None;
			if (!selected)
			{
				return false;
			}
			else
			{
				Rectangle rectInner = Rectangle.Round(Path.GetBounds());
				Rectangle rectOuter = rectInner;
				rectOuter.Inflate(new Size(focusBorderSpace, focusBorderSpace));
				if (rectOuter.Contains(point) && !rectInner.Contains(point))
				{
					// Here's the simplest hit-testing code.
					// However, it's insufficient because it doesn't indicate
					// the side where the hit took place.
				}
				else
				{
					return false;
				}

				bool top = false;
				bool bottom = false;
				bool left = false;
				bool right = false;
				if (Math.Abs(point.X - location.X) < focusBorderSpace)
				{
					left = true;
				}
				if (Math.Abs(point.X - (location.X + size.Width)) < focusBorderSpace)
				{
					right = true;
				}
				if (Math.Abs(point.Y - location.Y) < focusBorderSpace)
				{
					top = true;
				}
				if (Math.Abs(point.Y - (location.Y + size.Height)) < focusBorderSpace)
				{
					bottom = true;
				}
				if (top && left) hitSpot = HitSpot.TopLeftCorner;
				else if (top && right) hitSpot = HitSpot.TopRightCorner;
				else if (bottom && left) hitSpot = HitSpot.BottomLeftCorner;
				else if (bottom && right) hitSpot = HitSpot.BottomRightCorner;
				else if (top) hitSpot = HitSpot.Top;
				else if (bottom) hitSpot = HitSpot.Bottom;
				else if (left) hitSpot = HitSpot.Left;
				else if (right) hitSpot = HitSpot.Right;

				if (hitSpot == HitSpot.None)
					return false;
				else
					return true;
			}
		}

		// The following properties duplicate some of the Control-class
		// functionality that's needed.
		private Color foreColor;
		public Color ForeColor
		{
			get
			{
				return foreColor;
			}
			set
			{
				foreColor = value;
			}
		}

		private Color backColor;
		public Color BackColor
		{
			get
			{
				return backColor;
			}
			set
			{
				backColor = value;
			}
		}

		private int zOrder;
		public int ZOrder
		{
			get
			{
				return zOrder;
			}
			set
			{
				zOrder = value;
			}
		}

		private bool selected;
		public bool Selected
		{
			get
			{
				return selected;
			}
			set
			{
				selected = value;
			}
		}

		private Size size;
		public Size Size
		{
			get
			{
				return size;
			}
			set
			{
				size = value;
				path = null;
			}
		}

		private Point location;
		public Point Location
		{
			get
			{
				return location;
			}
			set
			{
				location = value;
				path = null;
			}
		}

		// These details could be wrapped in properties
		// to provide more customization for line thickness
		// and border patterns.
		private int penThickness = 3;
		private int focusBorderSpace = 5;
		[NonSerialized]
		Pen outlinePen;

		public void Render(Graphics g)
		{
			// Create the pen and brush.
			if (outlinePen != null)
			{
			    outlinePen.Dispose();
			}
			
			outlinePen = new Pen(foreColor, penThickness);
			Brush surfaceBrush = new SolidBrush(backColor);

			// Paint the shape.
			g.FillPath(surfaceBrush, Path);
			g.DrawPath(outlinePen, Path);

			// If required, paint the focus box.
			if (Selected)
			{
				Rectangle rect = Rectangle.Round(Path.GetBounds());
				rect.Inflate(new Size(focusBorderSpace, focusBorderSpace));
				ControlPaint.DrawFocusRectangle(g, rect);
			}
			surfaceBrush.Dispose();
		}
	}
}
