using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DocumentView
{
	public partial class Child : Form
	{
		public Child()
		{
			InitializeComponent();
		}
		public enum ViewType
		{
			ItemGrid,
			PrintPreview
		}

		public Order Document;

		public Child(Order doc, ViewType viewType)
			: this()
		{
			// Configure the title.
			this.Text = doc.LastFileName;
			this.Document = doc;

			// Create a reference for the view.
			// This reference can accomodate any type of control.
			Control view = null;

			// Instantiate the appropriate view.
			switch (viewType)
			{
				case ViewType.ItemGrid:
					view = new OrderGridView(doc);
					break;
				case ViewType.PrintPreview:
					view = new OrderPrintPreview(doc);
					break;
			}

			// Add the view to the form.
			view.Dock = DockStyle.Fill;
			this.Controls.Add(view);
		}
	}
}