using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Strips
{
	public partial class ToolStripImages : Form
	{
		public ToolStripImages()
		{
			InitializeComponent();
		}

		private void ToolStripImages_Load(object sender, EventArgs e)
		{
			lstRelationship.DataSource = Enum.GetNames(typeof(TextImageRelation));
		}

		private void newToolStripButton_Click(object sender, EventArgs e)
		{
			ToolStripItem item = (ToolStripItem)sender;
			MessageBox.Show("You clicked" + item.Text);
		}

		private void cmdApply_Click(object sender, EventArgs e)
		{
			TextImageRelation selection;
			selection = (TextImageRelation)Enum.Parse(typeof(TextImageRelation), lstRelationship.Text);
			foreach (ToolStripItem item in toolStrip1.Items)
			{
				item.TextImageRelation = selection;
			}
		}

	


	}
}