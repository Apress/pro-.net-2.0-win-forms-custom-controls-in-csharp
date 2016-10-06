using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace DrawingShapes
{
	//[Serializable]
	//public class CustomShape : Shape
	//{
	//    private GraphicsPath path;
	//    public GraphicsPath Path
	//    {
	//        get { return path; }
	//        set { path = value; }
	//    }
	//    protected override GraphicsPath GeneratePath()
	//    {
	//        return path;
	//    }
	//}

	[Serializable]
	public class RectangleShape : Shape
	{
		protected override GraphicsPath GeneratePath()
		{
			GraphicsPath path = new GraphicsPath();
			path.AddRectangle(new Rectangle(
			  Location.X, Location.Y, Size.Width, Size.Height));
			return path;
		}
	}

	[Serializable]
	public class EllipseShape : Shape
	{
		protected override GraphicsPath GeneratePath()
		{
			GraphicsPath path = new GraphicsPath();
			path.AddEllipse(
			  Location.X, Location.Y, Size.Width, Size.Height);
			return path;
		}
	}

	[Serializable]
	public class TriangleShape : Shape
	{
		protected override GraphicsPath GeneratePath()
		{
			GraphicsPath path = new GraphicsPath();
			Point pt1 = new Point(
				Location.X + Size.Width / 2, Location.Y);
			Point pt2 = new Point(
				Location.X, Location.Y + Size.Height);
			Point pt3 = new Point(
				Location.X + Size.Width, Location.Y + Size.Height);
			path.AddPolygon(new Point[] { pt1, pt2, pt3 });
			return path;
		}
	}

}
