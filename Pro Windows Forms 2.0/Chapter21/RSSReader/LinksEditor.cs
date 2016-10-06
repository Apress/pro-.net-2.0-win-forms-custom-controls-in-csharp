using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Windows.Forms.Samples.RSS;

namespace System.Windows.Forms.Samples
{
	public partial class LinksEditor : Form
	{
		public LinksEditor()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Save
			RssLink.Save();
			this.Close();
		}

		private void LinksEditor_Load(object sender, EventArgs e)
		{
			// Load and bind
            this.RssLinkBindingSource.DataSource = RssLink.Links;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void RssLinkBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if ((this.RssLinkBindingSource.Count == 0) || (RssLinkBindingSource.Position == 0))
            {
                this.upButton.Enabled = false;
            }
            else
            {
                this.upButton.Enabled = true;
            }

            if ((this.RssLinkBindingSource.Count == 0) || (this.RssLinkBindingSource.Position == (this.RssLinkBindingSource.Count - 1)))
            {
                this.downButton.Enabled = false;
            }
            else
            {
                this.downButton.Enabled = true;
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            RssLink link = this.RssLinkBindingSource.Current as RssLink;
            int     pos = this.RssLinkBindingSource.Position;

            // Move item up
            if (null != link)
            {
                this.RssLinkBindingSource.RemoveCurrent();
                this.RssLinkBindingSource.Insert(pos - 1, link);

                // Set new position
                this.RssLinkBindingSource.Position = pos - 1;
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            RssLink     link = this.RssLinkBindingSource.Current as RssLink;
            int         pos = this.RssLinkBindingSource.Position;

            // Move item up
            if (null != link)
            {
                this.RssLinkBindingSource.RemoveCurrent();
                this.RssLinkBindingSource.Insert(pos+1, link);

                // Set new position
                this.RssLinkBindingSource.Position = pos + 1;

                // Verify position (DGV bug)
                if (RssLinkBindingSource.Position != pos + 1)
                {
                    RssLinkBindingSource.MoveLast();
                }
            }
        }
	}
}