using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewTest
{
	public partial class ProportionateFill : Form
	{
		public ProportionateFill()
		{
			InitializeComponent();
		}

		private void ProportionateFill_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = Program.StoreDB.GetProducts();
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			foreach (DataGridViewColumn col in dataGridView1.Columns)
			{
				col.Visible = false;
			}
			// Retrieve the columns you need to work with.
			DataGridViewColumn colID = dataGridView1.Columns["ProductID"];
			DataGridViewColumn colModel = dataGridView1.Columns["ModelName"];
			DataGridViewColumn colDesc = dataGridView1.Columns["Description"];

			colID.Visible = true;
			colModel.Visible = true;
			colDesc.Visible = true;

			// Give much more weigth to the description.
			colID.FillWeight = 25;
			colModel.FillWeight = 25;
			colDesc.FillWeight = 100;

			// However, keep a minimum width that ensures
			// the first two columns are readable.
			// Another option in this scenario is to only
			// assign fill mode to the description column.
			colID.MinimumWidth = 75;
			colModel.MinimumWidth = 125;
			colDesc.MinimumWidth = 100;
		}
	}
}