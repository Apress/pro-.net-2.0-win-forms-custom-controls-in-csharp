using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Design;
using System.Drawing.Drawing2D;

namespace GradientPanelControl
{
    public class GradientFillEditor : UITypeEditor
    {

        public override bool GetPaintValueSupported(
            System.ComponentModel.ITypeDescriptorContext context)
        {
            return true;
        }

        public override void PaintValue(
            System.Drawing.Design.PaintValueEventArgs e)
        {
            GradientFill fill = (GradientFill)e.Value;
            LinearGradientBrush brush = new LinearGradientBrush(e.Bounds,
                fill.ColorA, fill.ColorB, fill.GradientFillStyle);

            // Paint the thumbnail.
            e.Graphics.FillRectangle(brush, e.Bounds);
        }
    }

}
