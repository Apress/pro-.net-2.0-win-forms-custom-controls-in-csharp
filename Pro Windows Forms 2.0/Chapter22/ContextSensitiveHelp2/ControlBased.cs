using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HelpTest
{
	/// <summary>
	/// Summary description for ControlBased.
	/// </summary>
	public class ControlBased : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.ListBox ListBox1;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.HelpProvider HelpProvider1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ControlBased()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.ListBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
			this.SuspendLayout();
			// 
			// TextBox1
			// 
			this.TextBox1.Location = new System.Drawing.Point(30, 135);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(208, 20);
			this.TextBox1.TabIndex = 11;
			this.TextBox1.Text = "TextBox1";
			// 
			// ListBox1
			// 
			this.ListBox1.Location = new System.Drawing.Point(26, 19);
			this.ListBox1.Name = "ListBox1";
			this.ListBox1.Size = new System.Drawing.Size(112, 95);
			this.ListBox1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 179);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(236, 68);
			this.label1.TabIndex = 9;
			this.label1.Text = "Select a control and press F1 here for a control-based help topic.";
			// 
			// ControlBased
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.TextBox1,
																		  this.ListBox1,
																		  this.label1});
			this.Name = "ControlBased";
			this.Text = "ControlBased";
			this.Load += new System.EventHandler(this.ControlBased_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void ControlBased_Load(object sender, System.EventArgs e)
		{
			HelpProvider1.HelpNamespace = "sample.chm";
			HelpProvider1.SetHelpKeyword(TextBox1, "1007.html");
			HelpProvider1.SetHelpNavigator(TextBox1, HelpNavigator.Topic);
			HelpProvider1.SetHelpKeyword(ListBox1, "1006.html");
			HelpProvider1.SetHelpNavigator(ListBox1, HelpNavigator.Topic);
		}
	}
}
