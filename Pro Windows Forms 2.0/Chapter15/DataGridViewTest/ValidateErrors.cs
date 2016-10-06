using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewTest
{
	public partial class ValidateErrors : Form
	{
		public ValidateErrors()
		{
			InitializeComponent();
		}

		private void ValidateErrors_Load(object sender, EventArgs e)
		{
			DataSet ds = Program.StoreDB.GetCategoriesAndProducts();
			dataGridView1.DataSource = ds.Tables["Products"];

		}

		private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			    // Check if it's an error during the commit stage.
			if ((e.Context & DataGridViewDataErrorContexts.Commit) ==
			  DataGridViewDataErrorContexts.Commit)
			{
				// Check the column.
				if (dataGridView1.Columns[e.ColumnIndex].Name == "CategoryID")
				{
					// Check if it's a constraint exception.
					if (e.Exception is System.Data.InvalidConstraintException)
					{
						MessageBox.Show("This category does not exist.");
						// The following two lines suppress the exception for this error
						// and cancel the attempted action (like row navigation) so focus
						// remains on the cell. However, these are the defaults, so these
						// lines aren't required.
						e.ThrowException = false;
						e.Cancel = true;
					}
					// Check if it's a formatting exception.
					else if ((e.Exception.InnerException != null) &&
					 (e.Exception.InnerException is FormatException))
					{
						MessageBox.Show("This field can only contain numbers.");
						e.ThrowException = false;
						e.Cancel = true;
					}
				}
			}
		}

		private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			string id = e.Row.Cells["ProductID"].FormattedValue.ToString();
			string name = e.Row.Cells["ModelName"].FormattedValue.ToString();

			DialogResult result = MessageBox.Show(
			  "Are you sure you want to delete product " + id + " - " + name + "?",
			  "Delete?", MessageBoxButtons.OKCancel);

			if (result == DialogResult.Cancel)
			{
				// Cancel the delete operation.
				e.Cancel = true;
			}

		}



		private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (dataGridView1.Columns[e.ColumnIndex].Name == "ProductImage")
			{
				if (System.IO.Path.GetExtension(e.FormattedValue.ToString()) != ".gif")
				{
					dataGridView1.Rows[e.RowIndex].ErrorText = "Invalid Product Image";
					dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText =
					  "The file name must end with '.gif'.";
				}
			}        
   

		}
	}
}