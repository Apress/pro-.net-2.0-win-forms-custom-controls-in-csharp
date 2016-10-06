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
	/// <summary>
	/// Summary description for GradientLabel.
	/// </summary>
	public class GradientPanel : Panel
	{	
		private GradientFill gradient = new GradientFill();

        public GradientPanel()
        {
            handlerGradientChanged = new EventHandler(GradientChanged);
            gradient.GradientChanged += handlerGradientChanged;
            ResizeRedraw = true;
        }

        private EventHandler handlerGradientChanged;

        private Brush gradientBrush;
        private Brush GradientBrush
        {
            get
            {
                if (gradientBrush == null)
                {
						gradientBrush =
							new LinearGradientBrush(ClientRectangle, gradient.ColorA,
							gradient.ColorB, gradient.GradientFillStyle);
                }
                return gradientBrush;
            }
        }
     
		public GradientFill GradientFill
		{
			get
			{
				return gradient;
			}
			set
			{
                gradient = value;
                if (handlerGradientChanged != null) gradient.GradientChanged -= handlerGradientChanged;
                handlerGradientChanged = new EventHandler(GradientChanged);
                gradient.GradientChanged += handlerGradientChanged;
                if (gradientBrush != null) gradientBrush.Dispose();
				gradientBrush = null;
                Invalidate();
            }
		}

		protected override void OnPaintBackground(
			System.Windows.Forms.PaintEventArgs e)
        {       
			// Fill the rest of the background
			e.Graphics.FillRectangle(GradientBrush, ClientRectangle);
        }
   

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (gradientBrush != null) gradientBrush.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            Invalidate();
        }
		
        private void GradientChanged(object sender, EventArgs e)
		{
            if (gradientBrush != null) gradientBrush.Dispose();
            gradientBrush = null;
			Invalidate();
		}

	}
	

}
