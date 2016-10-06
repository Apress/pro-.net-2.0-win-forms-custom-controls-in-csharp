using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace DataGridViewCustomization
{
	public class GradientRolloverCell : DataGridViewTextBoxCell
	{
		private static int inCell = -1;
        
		protected override void OnMouseEnter(int rowIndex)
		{
            inCell = rowIndex;            
            
            // Invalidate the cell.
            this.DataGridView.InvalidateCell(this.ColumnIndex, rowIndex);               
		}

		protected override void OnMouseLeave(int rowIndex)
		{
            inCell = -1;

            // Invalidate the cell.
            this.DataGridView.InvalidateCell(this.ColumnIndex, rowIndex);
		}

		protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
		{            
            // Is the mouse hovering over this cell?
            if ((inCell == rowIndex) &&
                ((cellState & DataGridViewElementStates.Selected) !=
                 DataGridViewElementStates.Selected))
            {
                // Get the rectangle where painting will take place.
                Rectangle rect = new Rectangle(cellBounds.X, cellBounds.Y,
                  cellBounds.Width - 1, cellBounds.Height - 1);

                // Render the custom cell background.
                Color gradientColor;
                GradientRolloverColumn gradientColumn = this.OwningColumn as GradientRolloverColumn;
                if (gradientColumn != null)
                {
                    gradientColor = ((GradientRolloverColumn)base.OwningColumn).GradientColor;
                }
                else
                {
                    gradientColor = Color.Blue;
                }


                using (LinearGradientBrush brush = new LinearGradientBrush(rect,
                  Color.White, gradientColor, 35f))
                {
                    graphics.FillRectangle(brush, rect);
                }

                base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState,
                  value, formattedValue, errorText, cellStyle, advancedBorderStyle,
                  paintParts & ~(DataGridViewPaintParts.Background | DataGridViewPaintParts.SelectionBackground));
            }
            else
            {
                // Perform the standard painting.
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState,
                  value, formattedValue, errorText, cellStyle, advancedBorderStyle,
                  paintParts);
            }            
		}
	}
	public class GradientRolloverColumn : System.Windows.Forms.DataGridViewColumn
	{
		public GradientRolloverColumn(Color gradientColor)
		{
			GradientColor = gradientColor;
			base.CellTemplate = new GradientRolloverCell();
		}

		private Color color;
		public Color GradientColor
		{
			get { return color; }
			set { color = value; }
		}

	}

}
