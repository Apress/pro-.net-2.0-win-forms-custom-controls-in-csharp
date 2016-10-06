using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Design;

namespace GradientPanelControl
{
    public class GradientFill
    {
        private Color colorA = Color.LightBlue;
        private Color colorB = Color.Purple;
        private LinearGradientMode gradientStyle = LinearGradientMode.ForwardDiagonal;

        public event EventHandler GradientChanged;

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
