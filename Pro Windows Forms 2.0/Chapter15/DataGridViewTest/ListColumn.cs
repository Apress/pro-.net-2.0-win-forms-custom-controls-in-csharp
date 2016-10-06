using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewTest
{
	public partial class ListColumn : Form
	{
		public ListColumn()
		{
			InitializeComponent();
		}

		private void ListColumn_Load(object sender, EventArgs e)
		{
			DataSet ds = Program.StoreDB.GetCategoriesAndProducts();
			dataGridView1.DataSource = ds.Tables["Products"];

			// Remove the auto-generated CategoryID column.
			dataGridView1.Columns.Remove("CategoryID");

			// Create a list column for the CategoryID.
			DataGridViewComboBoxColumn listCol = new DataGridViewComboBoxColumn();
			listCol.DisplayIndex = 0;
			listCol.HeaderText = "Category";

			// This column is bound to the Products.CategoryID field.
			listCol.DataPropertyName = "CategoryID";

			// The list is filled from the Categories table.
			listCol.DataSource = ds.Tables["Categories"];
			listCol.DisplayMember = "CategoryName";
			listCol.ValueMember = "CategoryID";

			// Add the column.
			dataGridView1.Columns.Add(listCol);

		}
	}
}