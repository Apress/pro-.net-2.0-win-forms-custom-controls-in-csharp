namespace MultithreadingClient
{
	partial class TaskManagerClient
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
            this.cmdFind = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listTasks = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Range = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.taskManager = new MultithreadingWorker.TaskManager();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.cmdFind);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtTo);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtFrom);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(443, 104);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Find Prime Numbers";
            // 
            // cmdFind
            // 
            this.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdFind.Location = new System.Drawing.Point(211, 28);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(112, 24);
            this.cmdFind.TabIndex = 5;
            this.cmdFind.Text = "Find Primes";
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.listTasks);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 271);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Searches";
            // 
            // listTasks
            // 
            this.listTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Range,
            this.Status});
            this.listTasks.Location = new System.Drawing.Point(11, 22);
            this.listTasks.MultiSelect = false;
            this.listTasks.Name = "listTasks";
            this.listTasks.Size = new System.Drawing.Size(417, 234);
            this.listTasks.TabIndex = 0;
            this.listTasks.UseCompatibleStateImageBehavior = false;
            this.listTasks.View = System.Windows.Forms.View.Details;
            this.listTasks.DoubleClick += new System.EventHandler(this.listTasks_DoubleClick);
            // 
            // ID
            // 
            this.ID.Name = "ID";
            this.ID.Text = "ID";
            this.ID.Width = 106;
            // 
            // Range
            // 
            this.Range.Name = "Range";
            this.Range.Text = "Range";
            this.Range.Width = 124;
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Text = "Status";
            this.Status.Width = 109;
            // 
            // taskManager
            // 
            this.taskManager.MaxThreads = 2;
            this.taskManager.WorkerCompleted += new MultithreadingWorker.WorkerCompletedEventHandler(this.taskManager_WorkerCompleted);
            this.taskManager.ReportWorkerProgress += new MultithreadingWorker.ReportWorkerProgressEventHandler(this.taskManager_ReportWorkerProgress);
            // 
            // TaskManagerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TaskManagerClient";
            this.Text = "Task Manager Client";
            this.Load += new System.EventHandler(this.TaskManagerClient_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.Button cmdFind;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.TextBox txtTo;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.TextBox txtFrom;
		private System.Windows.Forms.GroupBox groupBox2;
		private MultithreadingWorker.TaskManager taskManager;
		private System.Windows.Forms.ListView listTasks;
		private System.Windows.Forms.ColumnHeader ID;
		private System.Windows.Forms.ColumnHeader Range;
		private System.Windows.Forms.ColumnHeader Status;
	}
}