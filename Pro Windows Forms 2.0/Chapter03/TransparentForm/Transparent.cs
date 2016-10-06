using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TransparentForm
{
	public partial class Transparent : Form
	{
		public Transparent()
		{
			InitializeComponent();
		}

		private void cmdApply_Click(object sender, EventArgs e)
		{
			this.Opacity = (double)udOpacity.Value / 100;
		}
	}
}