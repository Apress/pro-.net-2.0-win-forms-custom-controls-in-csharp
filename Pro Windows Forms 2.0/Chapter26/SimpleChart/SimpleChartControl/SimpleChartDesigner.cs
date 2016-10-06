#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;
using System.ComponentModel.Design;
#endregion

namespace SimpleChart
{
    public class SimpleChartDesigner : System.Windows.Forms.Design.ControlDesigner
    {
        private Pen pen;
        
         public override void Initialize(IComponent c)
         {
            base.Initialize(c);
            pen = new Pen(Color.Red);
            pen.DashStyle = DashStyle.Dash;
         }

        protected override void OnPaintAdornments(System.Windows.Forms.PaintEventArgs pe)
        {
            base.OnPaintAdornments(pe);

            // Add a border at design-time.
            pe.Graphics.DrawRectangle(pen, 0, 0, Control.Width - 1, Control.Height - 1);
            
        }
                
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (pen != null)
                    pen.Dispose();
            }
            base.Dispose(disposing);
        }

        
		protected override bool GetHitTest(System.Drawing.Point point)
		{
			point = Control.PointToClient(point);

			SimpleChart chart = (SimpleChart)Component;
            BarItem bar = chart.HitTest(point);

            // If the mouse is positioned over a bar,
            // allow the mouse events to occur.
            return (bar != null);
		}


    }
}
