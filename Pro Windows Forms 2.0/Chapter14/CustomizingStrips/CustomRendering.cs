using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Strips
{
	public partial class CustomRendering : Form
	{
		public CustomRendering()
		{
			InitializeComponent();
		}

		private void optPro_CheckedChanged(object sender, EventArgs e)
		{
			ToolStripManager.RenderMode = ToolStripManagerRenderMode.Professional;
		}

		private void optSys_CheckedChanged(object sender, EventArgs e)
		{
			ToolStripManager.RenderMode = ToolStripManagerRenderMode.System;
		}

		private void optCust_CheckedChanged(object sender, EventArgs e)
		{
			ToolStripManager.Renderer = new MyRenderer();
		}

        private void chkContentPanel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContentPanel.Checked)
            {
                toolStripContainer1.ContentPanel.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            }
            else
            {
                toolStripContainer1.ContentPanel.RenderMode = ToolStripRenderMode.System;
            }

        }
	}
}