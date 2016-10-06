using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LocalizableControl
{
	public partial class LocalizableUserControl : UserControl
	{
		public LocalizableUserControl()
		{
			InitializeComponent();
		}

		private string nonLocalizableText;
		public string NonLocalizableText
		{
			get { return nonLocalizable.Text; }
			set { nonLocalizable.Text = value; }
		}

		private string localizableText;
		[Localizable(true)]
		public string LocalizableText
		{
			get { return localizable.Text; }
			set { localizable.Text = value; }
		}
	}
}
