using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ProgressBarControl
{
	[ToolboxItem(false)]
	public partial class ProgressValueDropDown : UserControl
	{
		public ProgressValueDropDown()
		{
			// Default constructor required for designing
			// this control in Visual Studio.
			InitializeComponent();
		}
		

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			Value = trackBar1.Value;
			lblValue.Text = "Current Value = " + trackBar1.Value.ToString();
		}

		private int progressValue;
		public int Value
		{
			get { return progressValue; }
			set { progressValue = value; }
		}

		private IWindowsFormsEditorService editorService;
		
		public ProgressValueDropDown(int value, int maximum, IWindowsFormsEditorService editorService)
		{
			InitializeComponent();

			// Store this information for later use.
			Value = value;
			this.editorService = editorService;

			// Apply the current information.
			trackBar1.Maximum = maximum;
			lblRange.Text = "Allowed Range: (0, " + maximum.ToString() + ")";
			trackBar1.Value = value;
			
			trackBar1.SmallChange = 1;
			trackBar1.LargeChange = 5;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			editorService.CloseDropDown();
		}

	}
}
