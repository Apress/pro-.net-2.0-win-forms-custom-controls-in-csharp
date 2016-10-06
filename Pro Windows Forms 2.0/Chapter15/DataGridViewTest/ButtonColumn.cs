using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewTest
{
	public partial class ButtonColumn : Form
	{
		public ButtonColumn()
		{
			InitializeComponent();
		}

		private void ButtonColumn_Load(object sender, EventArgs e)
		{
			DataSet ds = Program.StoreDB.GetCategoriesAndProducts();
			dataGridView1.DataSource = ds.Tables["Categories"];

			DataGridViewButtonColumn detailsCol = new DataGridViewButtonColumn();
			detailsCol.Name = "Details";
			detailsCol.Text = "Details...";	
			
			detailsCol.UseColumnTextForButtonValue = true;
			dataGridView1.Columns.Insert(dataGridView1.Columns.Count, detailsCol);

			dataGridView1.AllowUserToAddRows = false;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridView1.Columns[e.ColumnIndex].Name == "Details")
			{
				// Create the new form.
				ChildForm frm = new ChildForm();

				// Provide the OrderID to the new form.
				frm.CategoryID = Convert.ToInt32(
				  dataGridView1.Rows[e.RowIndex].Cells["CategoryID"].Value);

				// Show the form.
				frm.ShowDialog();
				frm.Dispose();
			}

		}
	}
}