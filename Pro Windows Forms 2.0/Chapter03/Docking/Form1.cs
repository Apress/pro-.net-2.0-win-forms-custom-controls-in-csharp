using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Docking
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lstDockPanel.Items.AddRange(Enum.GetNames(Dock.GetType()));
			lstDockTextBox.Items.AddRange(Enum.GetNames(Dock.GetType()));

			lstDockPanel.Text = Enum.GetName(Dock.GetType(), pnlDock.Dock);
			lstDockTextBox.Text = Enum.GetName(Dock.GetType(), lstDockTextBox.Dock);
		}

		private void cmdUpdate_Click(object sender, EventArgs e)
		{
			this.DockPadding.All = (int)udDockPaddingForm.Value;
			pnlDock.DockPadding.All = (int)udDockPaddingPanel.Value;

			// Now we use some rather unusual code to translate the string
			//  in the listbox into an enumeration object that can be used
			//  to set the Dock property.
			// This looks quite strange, but is actually just one more
			//  part of the shared class library.

			// First we get the converter that can do the job.
			TypeConverter converter;
			converter = TypeDescriptor.GetConverter(Dock.GetType());

			// Then we use it to convert the string.
			pnlDock.Dock = (DockStyle)converter.ConvertFromString(lstDockPanel.Text);
			txtDock.Dock = (DockStyle)converter.ConvertFromString(lstDockTextBox.Text);

		}
	}
}