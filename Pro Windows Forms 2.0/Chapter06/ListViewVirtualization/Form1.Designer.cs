namespace ListViewVirtualization
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.listView = new System.Windows.Forms.ListView();
			this.imagesLarge = new System.Windows.Forms.ImageList(this.components);
			this.imagesSmall = new System.Windows.Forms.ImageList(this.components);
			this.lblStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listView
			// 
			this.listView.AllowColumnReorder = true;
			this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listView.GridLines = true;
			this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView.Location = new System.Drawing.Point(6, 5);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(402, 316);
			this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listView.TabIndex = 4;
			this.listView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listView_RetrieveVirtualItem);
			// 
			// imagesLarge
			// 
			this.imagesLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesLarge.ImageStream")));
			this.imagesLarge.Images.SetKeyName(0, "");
			// 
			// imagesSmall
			// 
			this.imagesSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesSmall.ImageStream")));
			this.imagesSmall.Images.SetKeyName(0, "");
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(12, 328);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(0, 0);
			this.lblStatus.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 350);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.listView);
			this.Name = "Form1";
			this.Text = "ListView Virtualization";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ImageList imagesLarge;
		private System.Windows.Forms.ImageList imagesSmall;
		private System.Windows.Forms.Label lblStatus;
	}
}

