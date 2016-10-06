namespace DocumentView
{
	partial class OrderGridView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmdRemove = new System.Windows.Forms.Button();
			this.cmdAdd = new System.Windows.Forms.Button();
			this.list = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// cmdRemove
			// 
			this.cmdRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdRemove.Location = new System.Drawing.Point(280, 37);
			this.cmdRemove.Name = "cmdRemove";
			this.cmdRemove.Size = new System.Drawing.Size(112, 28);
			this.cmdRemove.TabIndex = 8;
			this.cmdRemove.Text = "Remove Item";
			this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
			// 
			// cmdAdd
			// 
			this.cmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdAdd.Location = new System.Drawing.Point(280, 5);
			this.cmdAdd.Name = "cmdAdd";
			this.cmdAdd.Size = new System.Drawing.Size(112, 28);
			this.cmdAdd.TabIndex = 7;
			this.cmdAdd.Text = "Add Random Item";
			this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
			// 
			// list
			// 
			this.list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
			this.list.FullRowSelect = true;
			this.list.Location = new System.Drawing.Point(4, 5);
			this.list.MultiSelect = false;
			this.list.Name = "list";
			this.list.Size = new System.Drawing.Size(264, 136);
			this.list.TabIndex = 6;
			this.list.View = System.Windows.Forms.View.Details;
			// 
			// ColumnHeader1
			// 
			this.ColumnHeader1.Text = "ID";
			this.ColumnHeader1.Width = 30;
			// 
			// ColumnHeader2
			// 
			this.ColumnHeader2.Text = "Name";
			this.ColumnHeader2.Width = 100;
			// 
			// ColumnHeader3
			// 
			this.ColumnHeader3.Text = "Price";
			this.ColumnHeader3.Width = 50;
			// 
			// ColumnHeader4
			// 
			this.ColumnHeader4.Text = "Description";
			this.ColumnHeader4.Width = 200;
			// 
			// OrderGridView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cmdRemove);
			this.Controls.Add(this.cmdAdd);
			this.Controls.Add(this.list);
			this.Name = "OrderGridView";
			this.Size = new System.Drawing.Size(397, 146);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button cmdRemove;
		private System.Windows.Forms.Button cmdAdd;
		private System.Windows.Forms.ListView list;
		private System.Windows.Forms.ColumnHeader ColumnHeader1;
		private System.Windows.Forms.ColumnHeader ColumnHeader2;
		private System.Windows.Forms.ColumnHeader ColumnHeader3;
		private System.Windows.Forms.ColumnHeader ColumnHeader4;
	}
}
