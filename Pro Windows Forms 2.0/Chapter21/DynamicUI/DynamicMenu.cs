using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynamicUI
{
	public partial class DynamicMenu : Form
	{
		public DynamicMenu()
		{
			InitializeComponent();
		}

		private void panel_Enter(object sender, EventArgs e)
		{
			Panel panel = (Panel)sender;
            mnuTopLevel.DropDown = panel.ContextMenuStrip;
            ToolStripMenuItem item = (ToolStripMenuItem)panel.ContextMenuStrip.Items[0];
            mnuTopLevel.DropDown = item.DropDown;
            mnuTopLevel.Text = item.Text;                 		
		}

		private void panel_Leave(object sender, EventArgs e)
		{
			
			
		}


        private void DynamicMenu_Load(object sender, EventArgs e)
        {
            
        }
        
	}
}