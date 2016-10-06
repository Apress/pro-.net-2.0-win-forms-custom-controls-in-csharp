using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DataGridViewTest
{
	public partial class BoundImage : Form
	{
		public BoundImage()
		{
			InitializeComponent();
		}

		private void BoundImage_Load(object sender, EventArgs e)
		{
			// Bind the grid.
			dataGridView1.DataSource = Program.StoreDB.GetProducts();

			foreach (DataGridViewColumn col in dataGridView1.Columns)
			{
				col.Visible = false;
			}
			// Retrieve the columns you need to work with.
			DataGridViewColumn colID = dataGridView1.Columns["ProductID"];
			DataGridViewColumn colModel = dataGridView1.Columns["ModelName"];
			
			colID.Visible = true;
			colModel.Visible = true;
			
			// Create a new image column.
			DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
			imageCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			imageCol.ImageLayout = DataGridViewImageCellLayout.Normal;
			imageCol.Name = "Image";
			dataGridView1.Columns.Add(imageCol);

			// Make sure pictures are visible.
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			// Check if it's the Image column.
			if ((dataGridView1.Columns[e.ColumnIndex].Name == "Image"))
			{
				// Set the value based on the hidden ProductImage column.
				string fileName = Application.StartupPath + "\\" +
				  dataGridView1.Rows[e.RowIndex].Cells["ProductImage"].Value;
				if (File.Exists(fileName))
				{
					e.Value = Image.FromFile(fileName);
				}
			}
		}
	}
}