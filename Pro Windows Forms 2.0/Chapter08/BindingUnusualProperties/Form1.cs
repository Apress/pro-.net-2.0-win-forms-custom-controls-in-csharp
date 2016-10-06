using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Collections;

namespace BindingUnusualProperties
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// These are our final data sources: two ArrayList objects.
			List<Font> fontList = new List<Font>();
			List<Color> colorList = new List<Color>();

			// The InstalledFonts collection allows us to enumerate installed fonts.
			// Each FontFamily needs to be converted to a genuine Font object
			// before it is suitable for data binding to the Control.Font property.
			InstalledFontCollection InstalledFonts = new InstalledFontCollection();
			foreach (FontFamily family in InstalledFonts.Families)
			{
				try
				{
					fontList.Add(new Font(family, 12));
				}
				catch
				{
					// We end up here if the font could not be created
					// with the default style.
				}
			}

			// In order to retrieve the list of colors, we need to first retrieve
			// the strings for the KnownColor enumeration, and then convert each one
			// into a suitable color object.
			string[] colorNames;
			colorNames = System.Enum.GetNames(typeof(KnownColor));
			TypeConverter cnvrt = TypeDescriptor.GetConverter(typeof(KnownColor));

			foreach (string colorName in colorNames)
			{
				colorList.Add(Color.FromKnownColor((KnownColor)cnvrt.ConvertFromString(colorName)));
			}

			// We can now bind both our list controls.
			lstColors.DataSource = colorList;
			lstColors.DisplayMember = "Name";
			lstFonts.DataSource = fontList;
			lstFonts.DisplayMember = "Name";

			// The label is bound to both data sources.
			lblSampleText.DataBindings.Add("ForeColor", colorList, "");
			lblSampleText.DataBindings.Add("Font", fontList, "");

		}
	}
}