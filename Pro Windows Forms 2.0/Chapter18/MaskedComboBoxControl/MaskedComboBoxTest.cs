using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaskedComboBoxControl
{
	public partial class MaskedComboBoxTest : Form
	{
		public MaskedComboBoxTest()
		{
			InitializeComponent();
		}

		private void MaskedComboBoxTest_Load(object sender, EventArgs e)
		{
			maskedComboBox1.Mask = maskedTextBox1.Mask;
			
		}
	}
}