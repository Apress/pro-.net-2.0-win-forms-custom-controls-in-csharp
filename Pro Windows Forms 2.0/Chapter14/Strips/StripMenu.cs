using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Strips
{
	public partial class StripMenu : Form
	{
		
		public StripMenu()
		{
			InitializeComponent();
		}

		private void StripMenu_Load(object sender, EventArgs e)
		{
					
			// Create the font collection.
			InstalledFontCollection fontFamilies = new InstalledFontCollection();

			// Iterate through all font families.
			foreach (FontFamily family in fontFamilies.Families)
			{
				try
				{
					// Create a ToolStripMenuItem that will display text in this font.
					ToolStripMenuItem item = new ToolStripMenuItem(family.Name);
					item.Font = new Font(family, 8);

					mnuFont.DropDownItems.Add(item);
				}
				catch
				{
					// An error will occur if the selected font does
					// not support normal style (the default used when
					// creating a Font object). This problem can be
					// harmlessly ignored.
				}

			}

			// Code for the table-like File menu:
			
            // Create a new drop-down menu.
			ToolStripDropDown menu = new ToolStripDropDown();

            // Copy the existing items.
            ToolStripItem[] items = new ToolStripItem[fileToolStripMenuItem.DropDown.Items.Count];
            fileToolStripMenuItem.DropDown.Items.CopyTo(items, 0);

            // Transfer the items into the drop-down menu.
			foreach (ToolStripItem item in items)
			{
				if (!(item is ToolStripSeparator)) menu.Items.Add(item);
			}

            // Adjust the layout of the new menu.
			menu.LayoutStyle = ToolStripLayoutStyle.Table;
			((TableLayoutSettings)menu.LayoutSettings).ColumnCount = 2;
            			
            // Attach it to the File menu.
            fileToolStripMenuItem.DropDown = menu;
		}

		private void menuStrip1_MenuActivate(object sender, EventArgs e)
		{
			
		}
	}
}