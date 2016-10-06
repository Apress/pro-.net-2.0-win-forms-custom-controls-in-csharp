using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Strips
{
	public partial class CustomToolStripItem2 : Form
	{
		public CustomToolStripItem2()
		{
			InitializeComponent();
		}

		private void CustomToolStripItem2_Load(object sender, EventArgs e)
		{
			CheckTextBoxToolStripItem item = new CheckTextBoxToolStripItem();
			toolStrip1.Items.Add(item);

		}
	}


	[ToolboxBitmap(typeof(Button))]
	[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip)]
	public class CheckTextBoxToolStripItem : ToolStripControlHost
	{
		// Controls in this item.
		private FlowLayoutPanel controlPanel;
		private CheckBox chk = new CheckBox();
		private TextBox txt = new TextBox();
		
		public CheckTextBoxToolStripItem() : base(new FlowLayoutPanel())
		{
			// Set up the FlowLayouPanel.
			controlPanel = (FlowLayoutPanel)base.Control;
			controlPanel.BackColor = Color.Transparent;

			// Add two child controls.
			chk.AutoSize = true;
			controlPanel.Controls.Add(chk);
			controlPanel.Controls.Add(txt);

			TextEnabled = true;
			}

		
		public bool TextEnabled
		{
			get { return chk.Checked; }
			set { chk.Checked = value; }
		}

		protected override void OnSubscribeControlEvents(Control control)
		{
			chk.CheckedChanged += new EventHandler(CheckedChanged);
		}

		protected override void OnUnsubscribeControlEvents(Control control)
		{
			chk.CheckedChanged -= new EventHandler(CheckedChanged);
		}

		private void CheckedChanged(object sender, EventArgs e)
		{
			// Enable or disable the TextBox according to the 
			// current CheckBox selection.
			txt.Enabled = TextEnabled;
		}
	}

	public class CustomToolStripButton : ToolStripButton
	{
		protected override void OnPaint(PaintEventArgs pe)
		{
			Parent.Renderer.DrawButtonBackground(new ToolStripItemRenderEventArgs(pe.Graphics,this));
			pe.Graphics.DrawEllipse(Pens.Blue,0,0,this.Width,this.Height);
			pe.Graphics.FillEllipse(Brushes.Yellow, 0, 0, this.Width, this.Height);
		}
	}

}
