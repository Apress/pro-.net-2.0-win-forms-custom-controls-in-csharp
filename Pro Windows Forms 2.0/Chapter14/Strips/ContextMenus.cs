using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Strips
{
	public partial class ContextMenus : Form
	{
		public ContextMenus()
		{
			InitializeComponent();
		}

		private void ContextMenus_Load(object sender, EventArgs e)
		{
			
		}

		private void listBox1_MouseUp(object sender, MouseEventArgs e)
		{
		
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            // Enable everything.
            foreach (ToolStripItem item in contextMenuStrip1.Items)
            {
                item.Visible = true;
            }

            // Disable what isn't appropriate.
            if (contextMenuStrip1.SourceControl is Label)
            {
                cutToolStripMenuItem1.Visible = false;
                pasteToolStripMenuItem1.Visible = false;
            }

        }
	}
}