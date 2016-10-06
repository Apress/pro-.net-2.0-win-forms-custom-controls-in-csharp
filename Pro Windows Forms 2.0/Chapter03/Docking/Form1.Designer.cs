namespace Docking
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
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.cmdUpdate = new System.Windows.Forms.Button();
			this.udDockPaddingForm = new System.Windows.Forms.NumericUpDown();
			this.udDockPaddingPanel = new System.Windows.Forms.NumericUpDown();
			this.lstDockPanel = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.lstDockTextBox = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.pnlDock = new System.Windows.Forms.Panel();
			this.txtDock = new System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udDockPaddingForm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udDockPaddingPanel)).BeginInit();
			this.pnlDock.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.cmdUpdate);
			this.GroupBox1.Controls.Add(this.udDockPaddingForm);
			this.GroupBox1.Controls.Add(this.udDockPaddingPanel);
			this.GroupBox1.Controls.Add(this.lstDockPanel);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.lstDockTextBox);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(202, 20);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(284, 224);
			this.GroupBox1.TabIndex = 14;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Configure";
			// 
			// cmdUpdate
			// 
			this.cmdUpdate.Location = new System.Drawing.Point(160, 180);
			this.cmdUpdate.Name = "cmdUpdate";
			this.cmdUpdate.Size = new System.Drawing.Size(84, 24);
			this.cmdUpdate.TabIndex = 10;
			this.cmdUpdate.Text = "Update";
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			// 
			// udDockPaddingForm
			// 
			this.udDockPaddingForm.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.udDockPaddingForm.Location = new System.Drawing.Point(160, 32);
			this.udDockPaddingForm.Name = "udDockPaddingForm";
			this.udDockPaddingForm.Size = new System.Drawing.Size(52, 21);
			this.udDockPaddingForm.TabIndex = 4;
			// 
			// udDockPaddingPanel
			// 
			this.udDockPaddingPanel.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.udDockPaddingPanel.Location = new System.Drawing.Point(160, 56);
			this.udDockPaddingPanel.Name = "udDockPaddingPanel";
			this.udDockPaddingPanel.Size = new System.Drawing.Size(52, 21);
			this.udDockPaddingPanel.TabIndex = 5;
			this.udDockPaddingPanel.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// lstDockPanel
			// 
			this.lstDockPanel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstDockPanel.FormattingEnabled = true;
			this.lstDockPanel.Location = new System.Drawing.Point(156, 100);
			this.lstDockPanel.Name = "lstDockPanel";
			this.lstDockPanel.Size = new System.Drawing.Size(92, 21);
			this.lstDockPanel.TabIndex = 8;
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(16, 104);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(136, 20);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Dock Panel To:";
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(16, 128);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(136, 20);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Dock TextBox To:";
			// 
			// lstDockTextBox
			// 
			this.lstDockTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstDockTextBox.FormattingEnabled = true;
			this.lstDockTextBox.Location = new System.Drawing.Point(156, 124);
			this.lstDockTextBox.Name = "lstDockTextBox";
			this.lstDockTextBox.Size = new System.Drawing.Size(92, 21);
			this.lstDockTextBox.TabIndex = 9;
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(16, 60);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(136, 20);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Set Panel\'s DockPadding:";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(16, 36);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(136, 20);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Set Form\'s DockPadding:";
			// 
			// pnlDock
			// 
			this.pnlDock.Controls.Add(this.txtDock);
			this.pnlDock.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlDock.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlDock.Location = new System.Drawing.Point(0, 0);
			this.pnlDock.Name = "pnlDock";
			this.pnlDock.Padding = new System.Windows.Forms.Padding(20);
			this.pnlDock.Size = new System.Drawing.Size(224, 314);
			this.pnlDock.TabIndex = 13;
			// 
			// txtDock
			// 
			this.txtDock.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtDock.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDock.Location = new System.Drawing.Point(20, 20);
			this.txtDock.Multiline = true;
			this.txtDock.Name = "txtDock";
			this.txtDock.Size = new System.Drawing.Size(108, 274);
			this.txtDock.TabIndex = 0;
			this.txtDock.Text = "I\'m docked to the edge of this Panel.\r\n\r\nThe Panel is docked to the edge of the f" +
				"orm.\r\n\r\nThe Panel\'s DockPadding gives the necessary room to breathe.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 314);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.pnlDock);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "Docking At Work";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udDockPaddingForm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udDockPaddingPanel)).EndInit();
			this.pnlDock.ResumeLayout(false);
			this.pnlDock.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.Button cmdUpdate;
		private System.Windows.Forms.NumericUpDown udDockPaddingForm;
		private System.Windows.Forms.NumericUpDown udDockPaddingPanel;
		private System.Windows.Forms.ComboBox lstDockPanel;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.ComboBox lstDockTextBox;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Panel pnlDock;
		private System.Windows.Forms.TextBox txtDock;
	}
}

