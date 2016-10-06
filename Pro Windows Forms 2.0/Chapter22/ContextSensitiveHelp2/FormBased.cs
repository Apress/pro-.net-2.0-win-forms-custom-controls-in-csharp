using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HelpTest
{
	/// <summary>
	/// Summary description for FormBased.
	/// </summary>
	public class FormBased : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.HelpProvider HelpProvider1;
		internal System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormBased()
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
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(236, 68);
			this.label1.TabIndex = 6;
			this.label1.Text = "Press F1 here for a form-based help topic.";
			// 
			// FormBased
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1});
			this.Name = "FormBased";
			this.Text = "FormBased";
			this.Load += new System.EventHandler(this.FormBased_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FormBased_Load(object sender, System.EventArgs e)
		{
			HelpProvider1.HelpNamespace = "sample.chm";
			HelpProvider1.SetHelpKeyword(this, "1001.html");
			HelpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
        
		}
	}
}
