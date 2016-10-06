using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewTest
{
	public partial class CustomSorting : Form
	{
		public CustomSorting()
		{
			InitializeComponent();
		}

		private void CustomSorting_Load(object sender, EventArgs e)
		{
			DataTable dt = Program.StoreDB.GetProducts();
			dt.Columns.Add("InStock", typeof(Boolean));
			dataGridView1.DataSource = dt;

			foreach (DataGridViewColumn col in dataGridView1.Columns)
			{
				col.SortMode = DataGridViewColumnSortMode.Programmatic;
			}
			dataGridView1.Columns["InStock"].SortMode = DataGridViewColumnSortMode.Automatic;
		}

		private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{

		}

		private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (dataGridView1.Columns[e.ColumnIndex].Name == "InStock") return;
			dataGridView1.Sort(dataGridView1.Columns[e.ColumnIndex], ListSortDirection.Ascending);
			dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
		}
	}
}