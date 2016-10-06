using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace ListViewExample
{
	public class ListViewItemComparer : IComparer
	{
		private int column;
		public int Column
		{
			get { return column; }
			set { column = value; }
		}

		private bool numeric = false;
		public bool Numeric
		{
			get { return numeric; }
			set { numeric = value; }
		}

		private bool descending = false;
		public bool Descending
		{
			get { return descending; }
			set { descending = value; }
		}

		public ListViewItemComparer(int columnIndex)
		{
			Column = columnIndex;
		}

		public int Compare(object x, object y)
		{
			ListViewItem listX, listY;
			if (descending)
			{
				listY = (ListViewItem)x;
				listX = (ListViewItem)y;
			}
			else
			{
				listX = (ListViewItem)x;
				listY = (ListViewItem)y;
			}

			if (Numeric)
			{
				// Convert column text to numbers before comparing.
				// If the conversion fails, the value defaults to 0.
				decimal valX, valY;
				Decimal.TryParse(listX.SubItems[Column].Text, out valX);
				Decimal.TryParse(listY.SubItems[Column].Text, out valY);

				// Perform a numeric comparison.
				return Decimal.Compare(valX, valY);
			}
			else
			{
				// Perform an alphabetic comparison.
				return String.Compare(
				  listX.SubItems[Column].Text, listY.SubItems[Column].Text);
			}
		}
	}
}
