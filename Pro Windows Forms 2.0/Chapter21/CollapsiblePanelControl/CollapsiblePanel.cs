using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Collections;
using System.ComponentModel;

// Needed for advanced visual styles scenarios
using System.Windows.Forms.VisualStyles;

namespace Microsoft.Samples
{
	/// <summary>
	/// Summary description for CollapsiblePanel.
	/// </summary>

	// This disables the autodock smart tag
	[Docking(DockingBehavior.Never)]
	
	// Set the designer
	[Designer(typeof(CollapsiblePanelDesigner))]
	public class CollapsiblePanel : Panel
	{
		// Controls
		private CollapseButton button;
		private Timer timer;

		// Fields
		private bool collapsing;
		private int oldHeight;
		private int accelerator;
		private bool collapsed;

		public CollapsiblePanel()
		{
			this.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);

			this.DoubleBuffered = true;

			// Setup button
			button = new CollapseButton();
			button.Size = new Size(this.Width, 25);
			button.Location = new Point(0, 0);
			button.Font = new Font("Tahoma", 8.0f, FontStyle.Bold);
            button.Dock = DockStyle.Top;
            button.Click += new EventHandler(button_Click);
			this.Controls.Add(button);

			// Setup timer
			timer = new Timer();
			timer.Interval = 25;
			timer.Tick += new EventHandler(timer_Tick);
		}

		// Properties
		public bool Collapsed
		{
			get
			{
				return collapsed;
			}
			set
			{
				if (collapsed != value)
				{
					collapsed = value;
					if (collapsed)
					{
						PerformCollapse();
					}
					else
					{
						PerformExpand();
					}
				}
			}
		}

        [Browsable(true)]
		public override string Text
		{
			get
			{
				return button.Text;
			}
			set
			{
				button.Text = value;
			}
		}

		// Methods
		private void PerformCollapse() 
		{
			collapsing = true;
			SuspendLayout();
			timer.Enabled = true;
		}

		private void PerformExpand()
		{
			collapsing = false;
			SuspendLayout();
			timer.Enabled = true;
			
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			// Paint parent background
			InvokePaintBackground(this, new PaintEventArgs(e.Graphics, ClientRectangle));

			// Fill the rest of the background
			VisualStyleRenderer renderer = new VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupBackground.Normal);
			renderer.DrawBackground(e.Graphics, e.ClipRectangle);

			if (!timer.Enabled)
			{
				base.OnPaint(e);
			}
		}

		
		protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
		{
			base.SetBoundsCore(x, y, width, height, specified);
			// My new code
			if (!timer.Enabled && !collapsed)
			{
				oldHeight = Height;
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (collapsing)
			{
				this.Size = new Size(this.Width, this.Height - 2 - accelerator);
				if (this.Height <= 25)
				{
					this.Size = new Size(this.Width, 25);
					timer.Enabled = false;
					button.Collapsed = true;
					accelerator = 0;
					ResumeLayout();
				}
			}
			else
			{
				this.Size = new Size(this.Width, this.Height + 2 + accelerator);
				if (this.Height >= oldHeight)
				{
					this.Size = new Size(this.Width, oldHeight);
					timer.Enabled = false;
					button.Collapsed = false;
					accelerator = 0;
					ResumeLayout();
				}
			}
			accelerator++;
		}

		private void button_Click(object sender, EventArgs e)
		{
			if (!collapsing)
			{
				Collapsed = true;
			}
			else
			{
				Collapsed = false;
			}
		}
	}
}
