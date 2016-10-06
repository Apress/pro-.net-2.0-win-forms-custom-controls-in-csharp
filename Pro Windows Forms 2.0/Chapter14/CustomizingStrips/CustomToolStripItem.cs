using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Strips
{
	public partial class CustomToolStripItem : Form
	{
		public CustomToolStripItem()
		{
			InitializeComponent();
		}

		private void CustomToolStripItem_Load(object sender, EventArgs e)
		{
			DateTimePicker dt = new DateTimePicker();
			dt.Value = DateTime.Now;
			dt.Format = DateTimePickerFormat.Short;
			dt.Width /= 2;
			dt.Font = new Font("Tahoma", dt.Font.Size);
			item = new ToolStripControlHost(dt);
			toolStrip1.Items.Insert(1,item);
		}

		private ToolStripControlHost item;
		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("The current date is " + item.Text);
			MessageBox.Show("The current date is " + ((DateTimePicker)item.Control).Format.ToString());
			
		}
	}
}

