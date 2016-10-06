#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

#endregion

namespace System.Windows.Forms.Samples
{
	public class CustomToolStrip : ToolStrip
	{
        private CustomToolStripRenderer _renderer;

        public CustomToolStrip()
        {
			// Set defaults
			this.GripStyle = ToolStripGripStyle.Hidden;

			// Set renderer
            this._renderer = new CustomToolStripRenderer();

            // Look for headerText
			this.Renderer = this._renderer;
		}
	}

	#region Custom ToolStrip Renderer
	public class CustomToolStripRenderer : ToolStripProfessionalRenderer
	{
		public CustomToolStripRenderer()
		{
			this.RoundedEdges = false;
		}

		protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
		{
			if (e.Item.Selected)
			{
				e.TextColor = Color.FromArgb(255, 223, 127);
			}

			base.OnRenderItemText(e);
		}

		protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
		{
			if (!(e.Item.Selected))
			{
				base.OnRenderButtonBackground(e);
			}
		}
	}
	#endregion
}
