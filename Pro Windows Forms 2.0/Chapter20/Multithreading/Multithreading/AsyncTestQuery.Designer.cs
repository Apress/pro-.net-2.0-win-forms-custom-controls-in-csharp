namespace MultithreadingClient
{
    partial class AsyncTestQuery
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.cmdFind = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtTo);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtFrom);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox1.Location = new System.Drawing.Point(9, 11);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(223, 98);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Find Prime Numbers";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 60);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 20);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "To:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(80, 56);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 21);
            this.txtTo.TabIndex = 3;
            this.txtTo.Text = "500000";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 32);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 20);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "From:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(80, 28);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 21);
            this.txtFrom.TabIndex = 0;
            this.txtFrom.Text = "1";
            // 
            // cmdFind
            // 
            this.cmdFind.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdFind.Location = new System.Drawing.Point(37, 135);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(80, 24);
            this.cmdFind.TabIndex = 5;
            this.cmdFind.Text = "OK";
            
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(124, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            // 
            // AsyncTestQuery
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(252, 171);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdFind);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AsyncTestQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asynchronous Test";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button cmdFind;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtTo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtFrom;
        internal System.Windows.Forms.Button button1;

    }
}

