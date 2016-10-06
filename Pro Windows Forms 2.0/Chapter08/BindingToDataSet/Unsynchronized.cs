using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BindingToDataSet
{
	public partial class Unsynchronized : Form
	{
		public Unsynchronized()
		{
			InitializeComponent();
		}

		private void Unsynchronized_Load(object sender, EventArgs e)
		{
			// Make sure all the controls in the second group box have a different binding.
			grpB.BindingContext = new BindingContext();

			DataTable dt = Program.StoreDB.GetProducts();

			// Configure the first group.
			lstModelNameA.DataSource = dt;
			lstModelNameA.DisplayMember = "ModelName";

			// Configure the second group.
			lstModelNameB.DataSource = dt;
			lstModelNameB.DisplayMember = "ModelName";

		}
	}
}