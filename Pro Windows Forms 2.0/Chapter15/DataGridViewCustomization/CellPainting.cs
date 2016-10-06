using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DataGridViewCustomization
{
	public partial class CellPainting : Form
	{
		public CellPainting()
		{
			InitializeComponent();
		}

		private void CellPainting_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = Program.StoreDB.GetProducts();

		}

        //private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //    // Only paint the desired column and
        //    // don't paint headers.
        //    if ((e.ColumnIndex == 0) && (e.RowIndex >= 0))
        //    {
        //        // If the cell is selected, use the normal painting
        //        // instead of the custom painting.
        //        if ((e.State & DataGridViewElementStates.Selected) !=
        //         DataGridViewElementStates.Selected)
        //        {
        //            // Suppress normal cell painting.
        //            e.Handled = true;

        //            // Get the rectangle where painting will take place.
        //            Rectangle rect = new Rectangle(e.CellBounds.X, e.CellBounds.Y,
        //              e.CellBounds.Width - 1, e.CellBounds.Height - 1);
                    
        //            // Render the custom cell background.
        //            using (LinearGradientBrush brush = new LinearGradientBrush(rect,
        //              Color.White, Color.YellowGreen, 35f))
        //            {
        //                e.Graphics.FillRectangle(brush, rect);
        //            }
                    
        //            // Render the standard cell border.
        //            using (Pen pen = new Pen(dataGridView1.GridColor))
        //            {
        //                e.Graphics.DrawRectangle(pen, e.CellBounds.X - 1,
        //                  e.CellBounds.Y - 1, e.CellBounds.Width, e.CellBounds.Height);
        //            }

        //            // Render the cell text.
        //            string cellValue = e.FormattedValue.ToString();

        //            // Set the alignment settings. Unfortunately, there's no
        //            // straightforward way to get the cell style settings and
        //            // convert them to the text alignment values you need here.
        //            StringFormat format = new StringFormat();
        //            format.LineAlignment = StringAlignment.Center;
        //            format.Alignment = StringAlignment.Near;

        //            using (Brush valueBrush = new SolidBrush(e.CellStyle.ForeColor))
        //            {
        //                e.Graphics.DrawString(cellValue, e.CellStyle.Font, valueBrush,
        //                 rect, format);
        //            }
        //        }
        //    }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Only paint the desired column and
            // don't paint headers.
            if ((e.ColumnIndex == 0) && (e.RowIndex >= 0))
            {
                // If the cell is selected, use the normal painting
                // instead of the custom painting.
                if ((e.State & DataGridViewElementStates.Selected) !=
                 DataGridViewElementStates.Selected)
                {
                    // Suppress normal cell painting.
                    e.Handled = true;

                    // Get the rectangle where painting will take place.
                    Rectangle rect = new Rectangle(e.CellBounds.X, e.CellBounds.Y,
                      e.CellBounds.Width - 1, e.CellBounds.Height - 1);

                    // Render the custom cell background.
                    using (LinearGradientBrush brush = new LinearGradientBrush(rect,
                      Color.White, Color.YellowGreen, 35f))
                    {
                        e.Graphics.FillRectangle(brush, rect);
                    }
                    
                    // Paint the cell text, the border, and the error icon (if needed).
                    // Don't worry about the focus rectangle or selection background,
                    // because we aren't painting selected cells.
                    e.Paint(e.ClipBounds,
                        DataGridViewPaintParts.ContentForeground |
                        DataGridViewPaintParts.Border |
                        DataGridViewPaintParts.ErrorIcon |
                        DataGridViewPaintParts.Focus);                    
                }
            }
		}
	}
}