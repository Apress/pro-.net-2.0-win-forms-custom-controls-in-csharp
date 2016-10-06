using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.ComponentModel.Design;
using System.Collections;

namespace SimpleChart
{
	[Designer(typeof(SimpleChartDesigner))]
	public class SimpleChart : Control
	{
		private IContainer components;

		public SimpleChart()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call
			DoubleBuffered = true;
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// SimpleChart
			// 
			this.Size = new System.Drawing.Size(372, 228);
			this.Resize += new System.EventHandler(this.SimpleChart_Resize);
			this.ResumeLayout(false);

		}
		#endregion

		private BarItemCollection bars = new BarItemCollection();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public BarItemCollection Bars
		{
			get
			{
				return bars;
			}
			set
			{
				bars = value;
				RebuildChart();
			}
		}

		private List<Rectangle> barRectangles = new List<Rectangle>();

		public void RebuildChart()
		{
			int barWidth;
			float maxValue;
			
			if (bars.Count == 0)
			{
				return;
			}

			// Find out how much space a single bar can occupy.
			barWidth = (int)(base.Width / bars.Count);

			// Set the maximum value on the chart.
			maxValue = 0;

			// Determine the maximum value.
			foreach (BarItem bar in bars)
			{
				if (bar.Value > maxValue)
				{
					maxValue = bar.Value;
				}
			}

			// Create the rectangle shapes.
			barRectangles.Clear();

			// Track the x-coordinate while laying out the bars.
			int x = 0;
			// Leave some space at the top.
			int topMargin = 5;
			// Leave some space between bars.
			int barGap = 4;
			
			foreach (BarItem bar in bars)
			{
				int height = (int)(bar.Value / maxValue * (Height - topMargin));
				int top = Height - height;

				barRectangles.Add(new Rectangle(x + barGap / 2, top, barWidth - barGap, height));
				x += barWidth;
			}

			base.Invalidate();
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			// Fill the background.
			if (Application.RenderWithVisualStyles)
			{
				VisualStyleRenderer renderer = new VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupBackground.Normal);
				renderer.DrawBackground(e.Graphics, e.ClipRectangle);
			}
			else
			{
				// Use a solid fill with the BackColor.
				Brush brush = new SolidBrush(base.BackColor);
				e.Graphics.FillRectangle(brush, e.ClipRectangle);
				brush.Dispose();
			}
		}

		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			base.OnPaint(e);

			if (barRectangles.Count == 0) return;

			foreach (Rectangle rect in barRectangles)
			{		
				if (Application.RenderWithVisualStyles)
				{
					VisualStyleRenderer renderer = new VisualStyleRenderer(VisualStyleElement.StartPanel.UserPane.Normal);
					renderer.DrawBackground(e.Graphics, rect);
				}
				else
				{
					// Draw bar (two rectangles are used for a shadowed effect).
					int shadowMargin = 4;
					Rectangle rectShadow = rect;
					rectShadow.Offset(shadowMargin, shadowMargin);
										
					e.Graphics.FillRectangle(Brushes.White, rectShadow);
					e.Graphics.FillRectangle(Brushes.SteelBlue, rect);
				}
			}

			// Draw text separately so it's superimposed on any
			// overlapping bars.
			int index = 0;
			foreach (Rectangle rect in barRectangles)
			{
				// Get title.
				string text = bars[index].ShortForm;
				
				// Get the position.
				int textTopOffset = 10, textLeftOffset = 15;
				Point ptText = rect.Location;
				ptText.Offset(textTopOffset, textLeftOffset);

				// Draw the title.
				e.Graphics.DrawString(text, Font, Brushes.White,
					ptText);

				index++;
			}

			// Draw bottom line of the the grid.
			Pen pen = new Pen(Color.Black, 3);
			e.Graphics.DrawLine(pen, 0, Height - 1, Width,
				Height - 1);
			pen.Dispose();
			//e.Graphics.DrawLine(Pens.Black, 0, 0, 0, base.Height);

		}

		private ToolTip toolTip;
		protected override void OnMouseMove(MouseEventArgs e)
		{
            if (DesignMode) return;

            BarItem bar = HitTest(e.Location);
            if (bar != null)
            {
                // Get matching value.
                string text = String.Format("{0:C}", bar.Value);

                // Get point in form coordinates.
                Point pt = e.Location;
                pt.Offset(base.Location);
                toolTip.Show(text, base.FindForm(), pt);
                return;
            }
            else
            {
                // No bar found.
                toolTip.Hide(base.FindForm());
            }
		}
        
        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (DesignMode)
            {
                BarItem bar = HitTest(e.Location);

                if (bar != null)
                {
                    ISelectionService selectService =
                      (ISelectionService)GetService(typeof(ISelectionService));
                    ArrayList selection = new ArrayList();
                    selection.Add(bar);
                    selectService.SetSelectedComponents(selection);                    
                }
            
            }
        }


        public BarItem HitTest(Point p)
        {
            // Hit test all the bars.
            for (int i=0; i<barRectangles.Count; i++)
            {           
                if (barRectangles[i].Contains(p))
                {
                    return bars[i];             
                }                
            }
            return null;
        }

		private void SimpleChart_Resize(object sender, System.EventArgs e)
		{
			RebuildChart();
			base.Invalidate();
		}


	}
}
