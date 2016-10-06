using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewTest
{
	public partial class Wrapping : Form
	{
		public Wrapping()
		{
			InitializeComponent();
		}

		private void Wrapping_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = Program.StoreDB.GetProducts();
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


			colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			colModel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

			colDesc.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			colDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
		}
	}
}