using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormOwnership
{
	public partial class OwnerForm : Form
	{
		public OwnerForm()
		{
			InitializeComponent();
		}

		private OwnedForm frmOwned = new OwnedForm();

		private void OwnerForm_Load(object sender, System.EventArgs e)
		{
			this.Show();
			frmOwned.Show();
		}

		private void cmdAddOwnership_Click(object sender, System.EventArgs e)
		{
			this.AddOwnedForm(frmOwned);
			frmOwned.lblState.Text = "I'm Owned";
		}

		private void cmdReleaseOwnership_Click(object sender, System.EventArgs e)
		{
			this.RemoveOwnedForm(frmOwned);
			frmOwned.lblState.Text = "I'm Free!";
		}
	}
}