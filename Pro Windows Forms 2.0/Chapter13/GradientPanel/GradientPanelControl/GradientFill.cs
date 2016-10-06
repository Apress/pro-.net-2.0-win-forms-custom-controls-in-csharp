using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Design;

namespace GradientPanelControl
{
 //[TypeConverter(typeof(ExpandableObjectConverter)),
    [Editor(typeof(GradientFillEditor), typeof(UITypeEditor))]
    [TypeConverter(typeof(GradientFillConverter))]
    public class GradientFill
    {
        private Color colorA = Color.LightBlue;
        private Color colorB = Color.Purple;
        private LinearGradientMode gradientStyle = LinearGradientMode.ForwardDiagonal;

        public event EventHandler GradientChanged;

        [RefreshProperties(RefreshProperties.Repaint)]
        [NotifyParentProperty(true)]
        [DefaultValue(typeof(Color), "LightBlue")]
        public Color ColorA
        {
            get
            {
                return colorA;
            }
            set
            {
                colorA = value;
                OnGradientChanged(EventArgs.Empty);
            }
        }

        [RefreshProperties(RefreshProperties.Repaint)]
        [NotifyParentProperty(true)]
        [DefaultValue(typeof(Color), "Purple")]
        public Color ColorB
        {
            get
            {
                return colorB;
            }
            set
            {
                colorB = value;
                OnGradientChanged(EventArgs.Empty);
            }
        }

        [RefreshProperties(RefreshProperties.Repaint)]
        [NotifyParentProperty(true)]
        [DefaultValue(typeof(LinearGradientMode), "ForwardDiagonal")]
        public LinearGradientMode GradientFillStyle
        {
            get
            {
                return gradientStyle;
            }
            set
            {
                gradientStyle = value;
                OnGradientChanged(EventArgs.Empty);
            }
        }

        private void OnGradientChanged(EventArgs e)
        {
            if (GradientChanged != null)
            {
                GradientChanged(this, e);
            }
        }

        public GradientFill()
        {
        }
        public GradientFill(Color colorA, Color colorB, LinearGradientMode gradientFillStyle)
        {
            ColorA = colorA;
            ColorB = colorB;
            GradientFillStyle = gradientFillStyle;
        }
    }
    
}
