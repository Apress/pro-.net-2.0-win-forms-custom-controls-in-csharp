using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewTest
{
	public partial class Selection : Form
	{
		public Selection()
		{
			InitializeComponent();
		}

		private void Selection_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = Program.StoreDB.GetProducts();
		
		}

		private void cmdSelectionInfo_Click(object sender, EventArgs e)
		{
			DisplaySelection();
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			DisplaySelection();
		}

		private void DisplaySelection()
		{
			StringBuilder info = new StringBuilder();
			info.Append(String.Format("Selected Cells: {0}", dataGridView1.SelectedCells.Count));
			info.Append(Environment.NewLine);
			info.Append(String.Format("Selected Rows: {0}", dataGridView1.SelectedRows.Count));
			info.Append(Environment.NewLine);
			info.Append(String.Format("Selected Columns: {0}", dataGridView1.SelectedColumns.Count));
			info.Append(Environment.NewLine);

			info.Append("Values: ");
			info.Append(Environment.NewLine);
			foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
			{
				info.Append(String.Format("  {0} at ({1}, {2})", cell.Value, cell.RowIndex, cell.ColumnIndex));
				info.Append(Environment.NewLine);
			}

			if (dataGridView1.CurrentCell != null)
			{
				info.Append(String.Format("Current Cell Value: {0}", dataGridView1.CurrentCell.Value));
				info.Append(Environment.NewLine);
				info.Append(String.Format("Current Cell Location: ({0}, {1})", dataGridView1.CurrentCellAddress.X, dataGridView1.CurrentCellAddress.Y));
			}
			txtSelectionInfo.Text = info.ToString();
		}
	}
}