using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Strips
{
	public partial class CustomOverflow : Form
	{
		//private int textAndImageSize = 0;
		//private int textOnlySize = 0;
		public CustomOverflow()
		{
			InitializeComponent();

		
			//// Determine bar sizes.
			//foreach (ToolStripItem item in toolStrip2.Items)
			//{
			//    item.DisplayStyle = ToolStripItemDisplayStyle.Text;
			//    textOnlySize += item.Bounds.Width + item.Margin.Horizontal;
			//}
			//foreach (ToolStripItem item in toolStrip2.Items)
			//{
			//    item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
			//    textAndImageSize += item.Bounds.Width + item.Margin.Horizontal;
			//}
			//textAndImageSize += threshold;
			//textOnlySize += threshold;
		
		}

		//private enum ShrinkLevel
		//{
		//    ImageAndText,
		//    TextOnly,
		//    ImageOnly
		//}

		private int threshold = 25;
		// Track how far we've shrunk.
		//private ShrinkLevel shrinkAmount = ShrinkLevel.ImageAndText;


		private int MeasureToolStrip()
		{
			int totalItemWidth = 0;
			foreach (ToolStripItem item in toolStrip2.Items)
			{
				totalItemWidth += item.Bounds.Width + item.Margin.Horizontal;
			}
			return totalItemWidth + threshold;
		}

		// Occurs at the beginning of a layout operation.
		// Try enlarging the ToolStrip if needed.
		private void toolStrip2_Layout(object sender, LayoutEventArgs e)
		{
			if (toolStrip2.DisplayRectangle.Width > MeasureToolStrip())
			{
				// Right now everything fits.
				// Check if a larger size is appropriate.
				foreach (ToolStripItem item in toolStrip2.Items)
				{
					if (!(item is ToolStripSeparator))
					{
						// Look to expand any image-only buttons.
						if (item.DisplayStyle == ToolStripItemDisplayStyle.Image)
						{
							item.DisplayStyle = ToolStripItemDisplayStyle.Text;
							return;
						}
					}
				}

				// If we reach here, there are no image-only buttons.
				// Look to expand any text-only buttons.
				foreach (ToolStripItem item in toolStrip2.Items)
				{
					if (!(item is ToolStripSeparator))
					{
						if (item.DisplayStyle == ToolStripItemDisplayStyle.Text)
						{
							item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
							return;
						}
					}
				}
				// If we reach here, the bar is fully expanded.
			}
		}
		//private void toolStrip2_Layout(object sender, LayoutEventArgs e)
		//{
		//    if (shrinkAmount == ShrinkLevel.ImageAndText)
		//    {
		//        // We're already using the largest display mode,
		//        // so no enlargement is necessary.
		//        return;
		//    }

		//    if (toolStrip2.DisplayRectangle.Width > MeasureToolStrip())
		//    {
		//        // Right now everything fits.
		//        // Check if a larger size is appropriate.

		//        // Will ImageAndText fit?
		//        if (toolStrip2.DisplayRectangle.Width > textAndImageSize)
		//        {
		//            shrinkAmount = ShrinkLevel.ImageAndText;
		//            ChangeButtonSize(ToolStripItemDisplayStyle.ImageAndText);				
		//        }
		//        else if (shrinkAmount == ShrinkLevel.ImageOnly)
		//        {
		//            // Will TextOnly fit?
		//            if (toolStrip2.DisplayRectangle.Width > textOnlySize)
		//            {
		//                ChangeButtonSize(ToolStripItemDisplayStyle.Text);
		//            }
		//        }
				
		//    }
		//}

		// Occurs at the end of a layout operation.
		// Try removing any overflow menus by shrinking items.
		private void toolStrip2_LayoutCompleted(object sender, EventArgs e)
		{
			// Check if the overflow menu is in use.
			if (toolStrip2.OverflowButton.HasDropDownItems)
			{
				// Step backwards.
				for (int i = toolStrip2.Items.Count - 1; i >= 0; i--)
				{
					ToolStripItem item = toolStrip2.Items[i];
					if (!(item is ToolStripSeparator))
					{
						if (item.DisplayStyle == ToolStripItemDisplayStyle.ImageAndText)
						{
							item.DisplayStyle = ToolStripItemDisplayStyle.Text;
							return;
						}
					}
				}
				// If we reached here, all buttons are shrunk to text.
				// Try reducing them further.
				for (int i = toolStrip2.Items.Count-1; i >= 0; i--)
				{
					ToolStripItem item = toolStrip2.Items[i];
					if (!(item is ToolStripSeparator))
					{
						if (item.DisplayStyle == ToolStripItemDisplayStyle.Text)
						{
							item.DisplayStyle = ToolStripItemDisplayStyle.Image;
							return;
						}
					}
				}

				// If we reach here, the bar is fully collapsed.
			}
		}
		//private void toolStrip2_LayoutCompleted(object sender, EventArgs e)
		//{
		//    // Check if the overflow menu is in use.
		//    if (toolStrip2.OverflowButton.HasDropDownItems)
		//    {
		//        if (shrinkAmount == ShrinkLevel.ImageOnly)
		//        {
		//            // No more shrinking is possible. You may
		//            // as well fix up the overflow menu to show 
		//            // full text and image.
		//            foreach (ToolStripItem item in toolStrip2.Items)
		//            {
		//                if (item.Placement == ToolStripItemPlacement.Overflow)
		//                {
		//                    item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
		//                }
		//                else
		//                {
		//                    item.DisplayStyle = ToolStripItemDisplayStyle.Image;
		//                }
		//            }
		//            return;
		//        }
			
		//        // Will TextOnly fit?
		//        if (toolStrip2.DisplayRectangle.Width > textOnlySize)
		//        {
		//            shrinkAmount = ShrinkLevel.TextOnly;
		//            ChangeButtonSize(ToolStripItemDisplayStyle.Text);
		//        }
		//        // We need to go with ImageOnly.
		//        else
		//        {
		//            shrinkAmount = ShrinkLevel.ImageOnly;
		//            ChangeButtonSize(ToolStripItemDisplayStyle.Image);
		//        }			
		//    }
		//}
		private void ChangeButtonSize(ToolStripItemDisplayStyle displayStyle)
		{
			toolStrip2.SuspendLayout();
			foreach (ToolStripItem item in toolStrip2.Items)
			{
				if (!(item is ToolStripSeparator))
				{
					item.DisplayStyle = displayStyle;
				}
			}
			toolStrip2.ResumeLayout();
		}

		private void CustomOverflow_Load(object sender, EventArgs e)
		{
			
		}
	}
}