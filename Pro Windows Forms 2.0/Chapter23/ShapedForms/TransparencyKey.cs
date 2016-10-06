using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShapedForms
{
	public partial class TransparencyKey : Form
	{
		public TransparencyKey()
		{        
			InitializeComponent();
		}

		private void TransparencyKey_Load(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
        
		protected override void WndProc(ref Message m)
		{
			// Allow the base class to handle all messages first.
			base.WndProc(ref m);
			
			// Look for the WM_NCHITTEST message.
			int WM_NCHITTEST = 0x84;
			if (m.Msg == WM_NCHITTEST)
			{
				// Treat this click as a click on the caption.
				int HTCLIENT = 1;
				int HTCAPTION = 2;
				if (m.Result.ToInt32() == HTCLIENT)
					m.Result = (IntPtr)HTCAPTION;
			}
		}
	}
}
