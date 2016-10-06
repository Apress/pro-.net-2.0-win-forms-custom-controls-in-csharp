using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
// Needed for advanced visual styles scenarios
using System.Windows.Forms.VisualStyles;

namespace GradientPanelControl
{
    [Designer(typeof(GradientPanelDesigner))]
    public class GradientPanel : Panel
    {
        private LinearGradientBrush gradientBrush;
        private LinearGradientBrush GradientBrush
        {
            get
            {
                if (gradientBrush == null)
                {
                    gradientBrush =
                        new LinearGradientBrush(ClientRectangle, colorA,
                        colorB, gradientStyle);
                }
                return gradientBrush;
            }
        }

        private Color colorA = Color.LightBlue;
        private Color colorB = Color.Purple;
        private LinearGradientMode gradientStyle = LinearGradientMode.ForwardDiagonal;


        public Color ColorA
        {
            get
            {
                return colorA;
            }
            set
            {
                colorA = value;
                gradientBrush = null;
                Invalidate();
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
                gradientBrush = null;
                Invalidate();
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
                gradientBrush = null;
                Invalidate();
            }
        }

        public GradientPanel()
        {
            ResizeRedraw = true;
        }
        
        protected override void OnPaintBackground(
            System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillRectangle(GradientBrush, ClientRectangle);
        }
        
        protected override void OnScroll(ScrollEventArgs se)
        {
            Invalidate();
        }
    }
	

}
