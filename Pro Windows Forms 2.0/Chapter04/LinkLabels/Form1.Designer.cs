namespace LinkLabels
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
            this.lnkBuy = new System.Windows.Forms.LinkLabel();
            this.lnkWebSite = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnkBuy
            // 
            this.lnkBuy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkBuy.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.lnkBuy.Location = new System.Drawing.Point(45, 100);
            this.lnkBuy.Name = "lnkBuy";
            this.lnkBuy.Size = new System.Drawing.Size(244, 48);
            this.lnkBuy.TabIndex = 7;
            this.lnkBuy.Text = "Buy it at Amazon.com or Barnes and Noble.";
            this.lnkBuy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebSite_Clicked);
            // 
            // lnkWebSite
            // 
            this.lnkWebSite.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkWebSite.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.lnkWebSite.Location = new System.Drawing.Point(45, 56);
            this.lnkWebSite.Name = "lnkWebSite";
            this.lnkWebSite.Size = new System.Drawing.Size(248, 36);
            this.lnkWebSite.TabIndex = 6;
            this.lnkWebSite.Text = "See www.prosetech.com for more information.";
            this.lnkWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebSite_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 204);
            this.Controls.Add(this.lnkBuy);
            this.Controls.Add(this.lnkWebSite);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Link Labels";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.LinkLabel lnkBuy;
		private System.Windows.Forms.LinkLabel lnkWebSite;
	}
}

