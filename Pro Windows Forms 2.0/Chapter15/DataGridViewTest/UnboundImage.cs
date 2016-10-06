using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewTest
{
	public partial class UnboundImage : Form
	{
		public UnboundImage()
		{
			InitializeComponent();
		}

		private Image genericImage;
		private Image newImage;

		private void UnboundImage_Load(object sender, EventArgs e)
		{
			genericImage = imageList.Images[1];
			newImage = imageList.Images[0];

			// Bind the grid.
			dataGridView1.DataSource = Program.StoreDB.GetProducts();

			// Create the image column.
			DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
			imageCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			imageCol.ImageLayout = DataGridViewImageCellLayout.Normal;
			imageCol.Frozen = true;
			imageCol.Name = "Image";
			imageCol.HeaderText = "";

			// Move the column to the left, and move the ProductID
			// column out of the way.
			imageCol.DisplayIndex = 0;
			dataGridView1.Columns["ProductID"].DisplayIndex = 1;

			// By default, show the generic image.
			imageCol.Image = genericImage;

			// Add the image column to the grid.
			dataGridView1.Columns.Add(imageCol);

		}

		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				// Retrieve the image column for this row.
				DataGridViewImageCell col =
				  (DataGridViewImageCell)dataGridView1.Rows[e.RowIndex].Cells["Image"];

				// Set the image.
				col.Value = newImage;
			}
		}
	}
}