using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AuthenticDragAndDrop
{
	public partial class Palette : Form
	{
		public Palette()
		{
			InitializeComponent();
		}

		private void lbl_MouseDown(object sender, MouseEventArgs e)
		{
			Label lbl = (Label)sender;
			lbl.DoDragDrop(lbl.Image, DragDropEffects.Copy);

		}
	}
}