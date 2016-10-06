namespace ListViewExample
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
			this.imagesSmall = new System.Windows.Forms.ImageList(this.components);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.optTile = new System.Windows.Forms.RadioButton();
			this.optLargeIcon = new System.Windows.Forms.RadioButton();
			this.optList = new System.Windows.Forms.RadioButton();
			this.optDetails = new System.Windows.Forms.RadioButton();
			this.optSmallIcon = new System.Windows.Forms.RadioButton();
			this.cmdFillList = new System.Windows.Forms.Button();
			this.imagesLarge = new System.Windows.Forms.ImageList(this.components);
			this.listView = new System.Windows.Forms.ListView();
			this.cmdResizeColumns = new System.Windows.Forms.Button();
			this.txtSelected = new System.Windows.Forms.TextBox();
			this.chkGroups = new System.Windows.Forms.CheckBox();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// imagesSmall
			// 
			this.imagesSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesSmall.ImageStream")));
			this.imagesSmall.Images.SetKeyName(0, "");
			// 
			// GroupBox1
			// 
			this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBox1.Controls.Add(this.chkGroups);
			this.GroupBox1.Controls.Add(this.optTile);
			this.GroupBox1.Controls.Add(this.optLargeIcon);
			this.GroupBox1.Controls.Add(this.optList);
			this.GroupBox1.Controls.Add(this.optDetails);
			this.GroupBox1.Controls.Add(this.optSmallIcon);
			this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.GroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupBox1.Location = new System.Drawing.Point(269, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(114, 177);
			this.GroupBox1.TabIndex = 8;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "View";
			// 
			// optTile
			// 
			this.optTile.Checked = true;
			this.optTile.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.optTile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optTile.Location = new System.Drawing.Point(16, 119);
			this.optTile.Name = "optTile";
			this.optTile.Size = new System.Drawing.Size(56, 16);
			this.optTile.TabIndex = 1;
			this.optTile.Tag = "";
			this.optTile.Text = "Tile";
			this.optTile.CheckedChanged += new System.EventHandler(this.NewView);
			// 
			// optLargeIcon
			// 
			this.optLargeIcon.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.optLargeIcon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optLargeIcon.Location = new System.Drawing.Point(16, 48);
			this.optLargeIcon.Name = "optLargeIcon";
			this.optLargeIcon.Size = new System.Drawing.Size(76, 16);
			this.optLargeIcon.TabIndex = 0;
			this.optLargeIcon.Text = "LargeIcon";
			this.optLargeIcon.CheckedChanged += new System.EventHandler(this.NewView);
			// 
			// optList
			// 
			this.optList.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.optList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optList.Location = new System.Drawing.Point(16, 96);
			this.optList.Name = "optList";
			this.optList.Size = new System.Drawing.Size(56, 16);
			this.optList.TabIndex = 0;
			this.optList.Text = "List";
			this.optList.CheckedChanged += new System.EventHandler(this.NewView);
			// 
			// optDetails
			// 
			this.optDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.optDetails.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optDetails.Location = new System.Drawing.Point(16, 72);
			this.optDetails.Name = "optDetails";
			this.optDetails.Size = new System.Drawing.Size(72, 16);
			this.optDetails.TabIndex = 0;
			this.optDetails.Text = "Details";
			this.optDetails.CheckedChanged += new System.EventHandler(this.NewView);
			// 
			// optSmallIcon
			// 
			this.optSmallIcon.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.optSmallIcon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optSmallIcon.Location = new System.Drawing.Point(16, 24);
			this.optSmallIcon.Name = "optSmallIcon";
			this.optSmallIcon.Size = new System.Drawing.Size(72, 16);
			this.optSmallIcon.TabIndex = 0;
			this.optSmallIcon.Text = "SmallIcon";
			this.optSmallIcon.CheckedChanged += new System.EventHandler(this.NewView);
			// 
			// cmdFillList
			// 
			this.cmdFillList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdFillList.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdFillList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdFillList.Location = new System.Drawing.Point(269, 195);
			this.cmdFillList.Name = "cmdFillList";
			this.cmdFillList.Size = new System.Drawing.Size(114, 24);
			this.cmdFillList.TabIndex = 7;
			this.cmdFillList.Text = "Fill List";
			this.cmdFillList.Click += new System.EventHandler(this.cmdFillList_Click);
			// 
			// imagesLarge
			// 
			this.imagesLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesLarge.ImageStream")));
			this.imagesLarge.Images.SetKeyName(0, "");
			// 
			// listView
			// 
			this.listView.AllowColumnReorder = true;
			this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listView.FullRowSelect = true;
			this.listView.GridLines = true;
			this.listView.Location = new System.Drawing.Point(7, 8);
			this.listView.MultiSelect = false;
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(254, 282);
			this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listView.TabIndex = 6;
			this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
			this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
			// 
			// cmdResizeColumns
			// 
			this.cmdResizeColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdResizeColumns.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdResizeColumns.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdResizeColumns.Location = new System.Drawing.Point(269, 225);
			this.cmdResizeColumns.Name = "cmdResizeColumns";
			this.cmdResizeColumns.Size = new System.Drawing.Size(114, 24);
			this.cmdResizeColumns.TabIndex = 9;
			this.cmdResizeColumns.Text = "Auto Resize Columns";
			this.cmdResizeColumns.Click += new System.EventHandler(this.cmdResizeColumns_Click);
			// 
			// txtSelected
			// 
			this.txtSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSelected.Location = new System.Drawing.Point(7, 296);
			this.txtSelected.Multiline = true;
			this.txtSelected.Name = "txtSelected";
			this.txtSelected.ReadOnly = true;
			this.txtSelected.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtSelected.Size = new System.Drawing.Size(254, 73);
			this.txtSelected.TabIndex = 10;
			// 
			// chkGroups
			// 
			this.chkGroups.AutoSize = true;
			this.chkGroups.Location = new System.Drawing.Point(14, 150);
			this.chkGroups.Name = "chkGroups";
			this.chkGroups.Size = new System.Drawing.Size(85, 17);
			this.chkGroups.TabIndex = 11;
			this.chkGroups.Text = "Show Groups";
			this.chkGroups.CheckedChanged += new System.EventHandler(this.chkGroups_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(390, 381);
			this.Controls.Add(this.txtSelected);
			this.Controls.Add(this.cmdResizeColumns);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.cmdFillList);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "ListView Example";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ImageList imagesSmall;
		private System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.RadioButton optTile;
		private System.Windows.Forms.RadioButton optLargeIcon;
		private System.Windows.Forms.RadioButton optList;
		private System.Windows.Forms.RadioButton optDetails;
		private System.Windows.Forms.RadioButton optSmallIcon;
		private System.Windows.Forms.Button cmdFillList;
		private System.Windows.Forms.ImageList imagesLarge;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.Button cmdResizeColumns;
		private System.Windows.Forms.TextBox txtSelected;
		private System.Windows.Forms.CheckBox chkGroups;
	}
}

