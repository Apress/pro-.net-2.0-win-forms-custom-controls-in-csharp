using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HelpTest
{
	/// <summary>
	/// Summary description for FrameBased.
	/// </summary>
	public class FrameBased : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.HelpProvider HelpProvider1;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.CheckBox CheckBox1;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.TextBox TextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrameBased()
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
			this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
			this.label1 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.CheckBox1 = new System.Windows.Forms.CheckBox();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.GroupBox2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 237);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(236, 40);
			this.label1.TabIndex = 9;
			this.label1.Text = "Press F1 in either frame for a frame-based help topic.";
			// 
			// GroupBox2
			// 
			this.GroupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.CheckBox1,
																					this.TextBox3});
			this.GroupBox2.Location = new System.Drawing.Point(14, 117);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(264, 96);
			this.GroupBox2.TabIndex = 8;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "GroupBox2";
			// 
			// CheckBox1
			// 
			this.CheckBox1.Location = new System.Drawing.Point(20, 64);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Size = new System.Drawing.Size(124, 16);
			this.CheckBox1.TabIndex = 3;
			this.CheckBox1.Text = "CheckBox1";
			// 
			// TextBox3
			// 
			this.TextBox3.Location = new System.Drawing.Point(20, 28);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(96, 20);
			this.TextBox3.TabIndex = 2;
			this.TextBox3.Text = "TextBox3";
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.TextBox2,
																					this.TextBox1});
			this.GroupBox1.Location = new System.Drawing.Point(14, 9);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(264, 96);
			this.GroupBox1.TabIndex = 7;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "GroupBox1";
			// 
			// TextBox2
			// 
			this.TextBox2.Location = new System.Drawing.Point(20, 56);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(96, 20);
			this.TextBox2.TabIndex = 1;
			this.TextBox2.Text = "TextBox2";
			// 
			// TextBox1
			// 
			this.TextBox1.Location = new System.Drawing.Point(20, 28);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(96, 20);
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "TextBox1";
			// 
			// FrameBased
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 286);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.GroupBox2,
																		  this.GroupBox1});
			this.Name = "FrameBased";
			this.Text = "FrameBased";
			this.Load += new System.EventHandler(this.FrameBased_Load);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrameBased_Load(object sender, System.EventArgs e)
		{
			HelpProvider1.HelpNamespace = "sample.chm";
			HelpProvider1.SetHelpKeyword(GroupBox1, "1003.html");
			HelpProvider1.SetHelpNavigator(GroupBox1, HelpNavigator.Topic);
			HelpProvider1.SetHelpKeyword(GroupBox2, "1004.html");
			HelpProvider1.SetHelpNavigator(GroupBox2, HelpNavigator.Topic);
		}
	}
}
