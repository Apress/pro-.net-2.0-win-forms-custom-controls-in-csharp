using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorChanger
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string[] colorNames;
			colorNames = System.Enum.GetNames(typeof(KnownColor));

			lstColors.Items.AddRange(colorNames);
		}

		private void lstColors_SelectedIndexChanged(object sender, EventArgs e)
		{
			KnownColor selectedColor;
			selectedColor = (KnownColor)System.Enum.Parse(typeof(KnownColor), lstColors.Text);

			this.BackColor = System.Drawing.Color.FromKnownColor(selectedColor);

			// Display color information.
			lblBrightness.Text = "Brightness = " +
							 this.BackColor.GetBrightness().ToString();
			lblHue.Text = "Hue = " + this.BackColor.GetHue().ToString();
			lblSaturation.Text = "Saturation = " + this.BackColor.GetSaturation().ToString();

		}
		

	}
}