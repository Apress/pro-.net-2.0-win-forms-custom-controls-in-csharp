namespace TestApp
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.designModeDialog1 = new Microsoft.Samples.DesignModeDialog();
			this.button3 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
// 
// tabControl1
// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(87, 88);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(403, 260);
			this.tabControl1.TabIndex = 0;
// 
// tabPage1
// 
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(395, 234);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
// 
// button2
// 
			this.button2.Location = new System.Drawing.Point(37, 178);
			this.button2.Name = "button2";
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
// 
// groupBox1
// 
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Location = new System.Drawing.Point(71, 62);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
// 
// button4
// 
			this.button4.Location = new System.Drawing.Point(53, 20);
			this.button4.Name = "button4";
			this.button4.TabIndex = 0;
			this.button4.Text = "button4";
// 
// tabPage2
// 
			this.tabPage2.Controls.Add(this.dataGridView1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(395, 234);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
// 
// dataGridView1
// 
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(389, 228);
			this.dataGridView1.TabIndex = 0;
// 
// button1
// 
			this.button1.Location = new System.Drawing.Point(323, 58);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Click to go to design mode";
			this.button1.Click += new System.EventHandler(this.button1_Click);
// 
// comboBox1
// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(81, 46);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.TabIndex = 1;
// 
// numericUpDown1
// 
			this.numericUpDown1.Location = new System.Drawing.Point(242, 28);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.TabIndex = 2;
// 
// designModeDialog1
// 
			this.designModeDialog1.HostForm = this;
			this.designModeDialog1.PropertiesToDesign.Add("Items");
			this.designModeDialog1.PropertiesToDesign.Add("AutoSize");
			this.designModeDialog1.PropertiesToDesign.Add("Size");
			this.designModeDialog1.PropertiesToDesign.Add("Text");
			this.designModeDialog1.PropertiesToDesign.Add("Font");
			this.designModeDialog1.PropertiesToDesign.Add("Location");
			this.designModeDialog1.PropertiesToDesign.Add("ForeColor");
			this.designModeDialog1.PropertiesToDesign.Add("BackColor");
			this.designModeDialog1.PropertiesToDesign.Add("Anchor");
			this.designModeDialog1.PropertiesToDesign.Add("Dock");
			this.designModeDialog1.PropertiesToDesign.Add("ClientSize");
// 
// button3
// 
			this.button3.Location = new System.Drawing.Point(25, 4);
			this.button3.Name = "button3";
			this.button3.TabIndex = 3;
			this.button3.Text = "button3";
// 
// Form1
// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(502, 360);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private Microsoft.Samples.DesignModeDialog designModeDialog1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;



	}
}

