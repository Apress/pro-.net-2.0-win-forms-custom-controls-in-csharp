using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Collections;
using System.ComponentModel;

// Necessary for low level visual style API calls
using System.Windows.Forms.VisualStyles;

// Necessary for GDI text API calls

namespace Microsoft.Samples
{
	/// <summary>
	/// Summary description for CollapseButton.
	/// </summary>
	public class CollapseButton : StateButtonBase
	{
		// Property fields
		private bool collapsed;

		public CollapseButton()
		{
			this.SetStyle(ControlStyles.ResizeRedraw
				| ControlStyles.OptimizedDoubleBuffer
				| ControlStyles.SupportsTransparentBackColor, true);

			this.DoubleBuffered = true;
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
				if (value != collapsed)
				{
					collapsed = value;
					Invalidate();
				}
			}
		}


        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }


        // Methods
		protected override void OnPaint(PaintEventArgs e)
		{
			VisualStyleRenderer renderer;

			// Paint parent background
			InvokePaintBackground(this, new PaintEventArgs(e.Graphics, ClientRectangle));

			// Paint background
			renderer = new VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupHead.Normal);
			renderer.DrawBackground(e.Graphics, new Rectangle(0, 0, e.ClipRectangle.Width, 25));

			// Draw Text
			Rectangle fontRect = new Rectangle(17, 6, this.Width - 17 - 24, this.Height);

			if ((State & StateButtonState.Pressed) != 0)
			{
				TextRenderer.DrawText(e.Graphics, this.Text, this.Font, fontRect, SystemColors.InactiveCaption, TextFormatFlags.Top | TextFormatFlags.Left);
			}
			else if ((State & StateButtonState.MouseHover) != 0)
			{
				TextRenderer.DrawText(e.Graphics, this.Text, this.Font, fontRect, SystemColors.InactiveCaption, TextFormatFlags.Top | TextFormatFlags.Left);
			}
			else if (!Enabled)
			{
				TextRenderer.DrawText(e.Graphics, this.Text, this.Font, fontRect, SystemColors.GrayText, TextFormatFlags.Top | TextFormatFlags.Left);
			}
			else
			{
				TextRenderer.DrawText(e.Graphics, this.Text, this.Font, fontRect, SystemColors.MenuHighlight, TextFormatFlags.Top | TextFormatFlags.Left);
			}

			// Draw button
			if (!collapsed)
			{
				// If pressed
				if ((State & StateButtonState.Pressed) != 0)
				{
					renderer = new VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupCollapse.Pressed);
				}

				// If hot
				else if ((State & StateButtonState.MouseHover) != 0)
				{
					renderer = new VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupCollapse.Hot);
				}

				// If disabled
				else if (!Enabled)
				{
					renderer = new VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupCollapse.Normal);
				}

				// If normal
				else
				{
					renderer = new VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupCollapse.Normal);
				}
			}
			else
			{
				// If pressed
				if ((State & StateButtonState.Pressed) != 0)
				{
					renderer = new VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupExpand.Pressed);
				}

				// If hot
				else if ((State & StateButtonState.MouseHover) != 0)
				{
					renderer = new VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupExpand.Hot);
				}

				// If disabled
				else if (!Enabled)
				{
					renderer = new VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupExpand.Normal);
				}

				// If normal
				else
				{
					renderer = new VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupExpand.Normal);
				}
			}

			renderer.DrawBackground(e.Graphics, new Rectangle(this.Width - 22, 3, 20, 20));

			base.OnPaint(e);
		}
	}
}
