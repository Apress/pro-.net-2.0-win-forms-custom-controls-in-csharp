using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace DocumentView
{
	public partial class OrderPrintPreview : UserControl
	{
		public OrderPrintPreview()
		{
			InitializeComponent();
		}

		private Order document;
		public Order Document
		{
			set
			{
				// Store a reference to the document, attach the event handler,
				// and refresh the display.
				document = value;
				document.DocumentChanged += new EventHandler(RefreshList);
				printDoc.PrintPage += new PrintPageEventHandler(PrintDoc);
				RefreshList();
			}
			get { return document; }
		}

		private PrintDocument printDoc = new PrintDocument();

		public OrderPrintPreview(Order document)
			: this()
		{
			// Store a reference to the document, attach the document event handlers,
			// and refresh the display.
			Document = document;

		}

		private void RefreshList(object sender, System.EventArgs e)
		{
			RefreshList();
		}

		private void RefreshList()
		{
			Preview.Document = printDoc;
            Preview.InvalidatePreview();
		}

		// Tracks placement while printing.
		private int itemNumber;

		// The print font.
		private Font printFont = new Font("Tahoma", 14, FontStyle.Bold);

		private void PrintDoc(object sender,
			System.Drawing.Printing.PrintPageEventArgs e)
		{

			// Tracks the line position on the page.
			int y = 70;

			// Step through the items and write them to the page.
			OrderItem item;
			Product itemProduct;

			for (itemNumber = 0; itemNumber < Document.Count; itemNumber++)
			{
				item = Document[itemNumber];
				e.Graphics.DrawString(item.ID.ToString(), printFont,
					Brushes.Black, 70, y);
				itemProduct = PriceList.GetItem(item.ID);
				e.Graphics.DrawString(itemProduct.Name, printFont,
					Brushes.Black, 120, y);
				e.Graphics.DrawString(itemProduct.Price.ToString(), printFont,
					Brushes.Black, 350, y);

				// Check if more pages are required.
				if ((y + 30) > e.MarginBounds.Height &&
					itemNumber < (Document.Count - 1))
				{
					e.HasMorePages = true;
					return;
				}

				// Move to the next line.
				y += 20;
			}

			// Printing is finished.
			e.HasMorePages = false;
			itemNumber = 0;
		}
	}
}
