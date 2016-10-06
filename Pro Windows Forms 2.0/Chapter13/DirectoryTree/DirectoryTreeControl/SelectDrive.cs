using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DirectoryTreeControl
{
	/// <summary>
	/// Summary description for SelectDrive.
	/// </summary>
	public class SelectDrive : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Button cmdClose;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ListBox lstDrives;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SelectDrive()
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
			this.cmdClose = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.lstDrives = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// cmdClose
			// 
			this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmdClose.Location = new System.Drawing.Point(80, 224);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(104, 24);
			this.cmdClose.TabIndex = 5;
			this.cmdClose.Text = "OK";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(8, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(208, 16);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Choose a Drive:";
			// 
			// lstDrives
			// 
			this.lstDrives.Location = new System.Drawing.Point(8, 24);
			this.lstDrives.Name = "lstDrives";
			this.lstDrives.Size = new System.Drawing.Size(248, 173);
			this.lstDrives.TabIndex = 3;
			// 
			// SelectDrive
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(266, 260);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.cmdClose,
																		  this.Label1,
																		  this.lstDrives});
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelectDrive";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SelectDrive";
			this.Load += new System.EventHandler(this.SelectDrive_Load);
			this.ResumeLayout(false);

		}
		#endregion

    public Char DriveSelection;

		private void SelectDrive_Load(object sender, System.EventArgs e)
		{
			string[] drives = System.IO.Directory.GetLogicalDrives();
			lstDrives.DataSource = drives;

			// Select the current drive.
			lstDrives.SelectedIndex = lstDrives.FindString(DriveSelection.ToString());

			// Attach the event handler.
			// This step is performed after the selected index is set,
			// to prevent it from being overwritten as the list is built.
			lstDrives.SelectedIndexChanged += new 
				EventHandler(lstDrives_SelectedIndexChanged);

		}

		private void lstDrives_SelectedIndexChanged(object sender,
			System.EventArgs e)
		{
			DriveSelection = lstDrives.Text[0];
		}

	}
}
