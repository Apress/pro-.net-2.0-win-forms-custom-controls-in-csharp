
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Strips
{


    public class MyRenderer : ToolStripRenderer
    {
        public MyRenderer()
            : base()
        {
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = Color.White;
            base.OnRenderItemText(e);
        }
        
        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            base.OnRenderImageMargin(e);

            Graphics g = e.Graphics;

            using (LinearGradientBrush b = new LinearGradientBrush(e.AffectedBounds, Color.Yellow, Color.Green, 0.0))
            {
                g.FillRectangle(b, e.AffectedBounds);
            }
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderMenuItemBackground(e);

            Graphics g = e.Graphics;

            if (e.Item.Selected || e.Item.Pressed)
            {
                using (LinearGradientBrush b = new LinearGradientBrush(new Rectangle(0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height), Color.LightGreen, Color.DarkGreen, 90))
                {
                    SolidBrush b1 = new SolidBrush(Color.Pink);
                    g.FillRectangle(b, 0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height);
                    b1.Dispose();
                }
            }
        }


        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderButtonBackground(e);

            // Check if the item is selected.
            LinearGradientBrush brush = null;
            if (e.Item.Pressed || e.Item.Selected)
            {
                brush = new LinearGradientBrush(e.Item.Bounds,
                 Color.FromArgb(Color.Yellow.R, Color.Yellow.G, Color.Yellow.B + 50),
                 Color.DarkGreen, 90);

                brush = new LinearGradientBrush(e.Item.Bounds,
                 Color.Yellow, Color.Green, 90);

                e.Graphics.FillRectangle(brush, 0, 0, e.Item.Width, e.Item.Height);
            }
        }


        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            Graphics g = e.Graphics;
            LinearGradientBrush b = new LinearGradientBrush(e.AffectedBounds, Color.DarkGray, Color.Black, 90);
            g.FillRectangle(b, e.AffectedBounds);
            b.Dispose();

            base.OnRenderToolStripBackground(e);
        }



    }
}

