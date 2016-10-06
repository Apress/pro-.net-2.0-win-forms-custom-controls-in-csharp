using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewTest
{
	public partial class AutoResize : Form
	{
		public AutoResize()
		{
			InitializeComponent();
		}

		private void AutoResize_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = Program.StoreDB.GetProducts();

			foreach (DataGridViewColumn col in dataGridView1.Columns)
			{
				col.Visible = false;
			}
			dataGridView1.Columns["ProductID"].Visible = true;
			dataGridView1.Columns["ModelName"].Visible = true;
			dataGridView1.Columns["Description"].Visible = true;

			lstAutoSizeRows.Items.AddRange(Enum.GetNames(typeof(DataGridViewAutoSizeRowsMode)));
			lstAutoSizeColumns.Items.AddRange(Enum.GetNames(typeof(DataGridViewAutoSizeColumnsMode)));

			lstAutoSizeColumns.Text = dataGridView1.AutoSizeColumnsMode.ToString();
			lstAutoSizeRows.Text = dataGridView1.AutoSizeRowsMode.ToString();

			
		}


		private void lst_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstAutoSizeColumns.Text == "" || lstAutoSizeRows.Text == "") return;
			dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)Enum.Parse(typeof(DataGridViewAutoSizeColumnsMode), lstAutoSizeColumns.Text);
			dataGridView1.AutoSizeRowsMode = (DataGridViewAutoSizeRowsMode)Enum.Parse(typeof(DataGridViewAutoSizeRowsMode), lstAutoSizeRows.Text);
		}

		private void optAllWrap_CheckedChanged(object sender, EventArgs e)
		{
			dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		}

		private void optNoWrap_CheckedChanged(object sender, EventArgs e)
		{
			dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
			dataGridView1.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
		}

		private void optWrapDesc_CheckedChanged(object sender, EventArgs e)
		{
			dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
			dataGridView1.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		}
	}
}