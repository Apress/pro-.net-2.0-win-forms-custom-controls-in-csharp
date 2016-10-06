using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewTest
{
	public partial class Unbound : Form
	{
		public Unbound()
		{
			InitializeComponent();
		}

		private void Unbound_Load(object sender, EventArgs e)
		{
			DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
			col1.Name = "ProductID";
			col1.HeaderText = "Product ID";
			dataGridView1.Columns.Add(col1);

			// The easiest way to add a column, with name and header text.
			dataGridView1.Columns.Add("ModelName", "Model Name");
			dataGridView1.Columns.Add("Description", "Description");
			dataGridView1.Columns.Add("UnitCost", "Unit Cost");
			dataGridView1.Columns["UnitCost"].ValueType = typeof(decimal);
			

			// Fill in a row of data (as a list of values).
			dataGridView1.Rows.Add(100, "Emergency Travel Gear", "Be prepared for vacation disasters.", 34.44m);
			
			// Add another row (the hard way).
			DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
			row.SetValues(101, "Supreme Flight", "Sail over the trees with this glider.", 138.25m);
			dataGridView1.Rows.Add(row);
			
			// Disable editing features.
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
		}

		private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{

		}
	}
}