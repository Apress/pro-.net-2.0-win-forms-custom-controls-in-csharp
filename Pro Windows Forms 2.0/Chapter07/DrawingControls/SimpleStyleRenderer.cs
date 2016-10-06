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
	public partial class SimpleStyleRenderer : Form
	{
		public SimpleStyleRenderer()
		{
			InitializeComponent();
		}

		private void SimpleStyleRenderer_Paint(object sender, PaintEventArgs e)
		{
			VisualStyleElement element = VisualStyleElement.Button.CheckBox.CheckedNormal;
			
			if (Application.RenderWithVisualStyles &&
				VisualStyleRenderer.IsElementDefined(element))
			{
				VisualStyleRenderer renderer = new VisualStyleRenderer(element);
				Rectangle rectCheck = new Rectangle(10, 10, 50, 50);
				Rectangle rectBox = new Rectangle(10, 10, 200, 50);
				Rectangle rectText = new Rectangle(50, 25, 150, 25);
				renderer.DrawBackground(e.Graphics, rectCheck);
				renderer.DrawEdge(e.Graphics, rectBox, 
					Edges.Bottom | Edges.Top | Edges.Left | Edges.Right,
					EdgeStyle.Etched, EdgeEffects.Flat);
				renderer.DrawText(e.Graphics, rectText, "Styled checkbox", false, TextFormatFlags.Top);
			}
			else
			{
				// (Perform ControlPaint drawing here.)
			}

		}
	}
}