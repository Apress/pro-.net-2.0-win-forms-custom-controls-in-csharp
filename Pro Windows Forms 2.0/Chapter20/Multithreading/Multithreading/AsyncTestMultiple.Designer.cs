namespace MultithreadingClient
{
    partial class AsyncTestMultiple
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdNewSearch = new System.Windows.Forms.ToolStripButton();
            
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusPanel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();

            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
// 
// toolStrip1
// 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.cmdNewSearch
            });
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
// 
// cmdNewSearch
// 
            this.cmdNewSearch.Name = "cmdNewSearch";
            
            this.cmdNewSearch.Text = "New Search";
            this.cmdNewSearch.Click += new System.EventHandler(this.cmdNewSearch_Click);
// 
// statusStrip1
// 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.statusPanel
            });
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
// 
// statusPanel
// 
            this.statusPanel.Name = "statusPanel";
// 
// AsyncTestMultiple
// 
            this.Controls.Add(toolStrip1);
            this.Controls.Add(statusStrip1);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(448, 401);
            this.IsMdiContainer = true;
            this.Name = "AsyncTestMultiple";
            this.Text = "Prime Number Searcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AsyncTestMultiple_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;        
        private System.Windows.Forms.ToolStripButton cmdNewSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusPanel;
    }
}