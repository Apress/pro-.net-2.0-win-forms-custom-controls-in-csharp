using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Strips
{
	public partial class StatusStripBorders : Form
	{
		public StatusStripBorders()
		{
			InitializeComponent();
		}

		private void StatusStripBorders_Load(object sender, EventArgs e)
		{
			string[] names = Enum.GetNames(typeof(Border3DStyle));
			comboBox1.Items.AddRange(names);
			comboBox2.Items.AddRange(names);
			comboBox3.Items.AddRange(names);
			names = Enum.GetNames(typeof(ToolStripStatusLabelBorderSides));
			checkedListBox1.Items.AddRange(names);
			checkedListBox2.Items.AddRange(names);
			checkedListBox3.Items.AddRange(names);
			groupBox1.Tag = toolStripStatusLabel1;
			groupBox2.Tag = toolStripStatusLabel2;
			groupBox3.Tag = toolStripStatusLabel3;

            comboBox1.Text = toolStripStatusLabel1.BorderStyle.ToString();
            comboBox2.Text = toolStripStatusLabel2.BorderStyle.ToString();
            comboBox3.Text = toolStripStatusLabel3.BorderStyle.ToString();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Border3DStyle selection;
			Control ctrl = (Control)sender;
			selection = (Border3DStyle)Enum.Parse(typeof(Border3DStyle), ctrl.Text);
			ToolStripStatusLabel lbl = (ToolStripStatusLabel)ctrl.Parent.Tag;
			if (lbl!=null) lbl.BorderStyle = selection;
		}



		private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			CheckedListBox ctrl = (CheckedListBox)sender;


			ToolStripStatusLabelBorderSides totalSelection = ToolStripStatusLabelBorderSides.None;
			foreach (string item in ctrl.CheckedItems)
			{
				ToolStripStatusLabelBorderSides selection = (ToolStripStatusLabelBorderSides)Enum.Parse(typeof(ToolStripStatusLabelBorderSides), item);

				totalSelection = totalSelection | selection;
			}

			ToolStripStatusLabel lbl = (ToolStripStatusLabel)ctrl.Parent.Tag;
			lbl.BorderSides = totalSelection;
		}
	}
}