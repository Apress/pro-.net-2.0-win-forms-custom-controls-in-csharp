namespace DynamicUI
{
    partial class DynamicDBMenu
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
            this.cmdAdmin = new System.Windows.Forms.Button();
            this.cmdUser = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageHardware = new System.Windows.Forms.ToolStripMenuItem();
            this.SetUpUserAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Contents = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdAdmin
            // 
            this.cmdAdmin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAdmin.Location = new System.Drawing.Point(159, 158);
            this.cmdAdmin.Name = "cmdAdmin";
            this.cmdAdmin.Size = new System.Drawing.Size(80, 24);
            this.cmdAdmin.TabIndex = 5;
            this.cmdAdmin.Text = "Admin Level";
            this.cmdAdmin.Click += new System.EventHandler(this.cmdAdmin_Click);
            // 
            // cmdUser
            // 
            this.cmdUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdUser.Location = new System.Drawing.Point(71, 158);
            this.cmdUser.Name = "cmdUser";
            this.cmdUser.Size = new System.Drawing.Size(80, 24);
            this.cmdUser.TabIndex = 4;
            this.cmdUser.Text = "User Level";
            this.cmdUser.Click += new System.EventHandler(this.cmdUser_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Tools,
            this.Help});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(306, 24);
            this.mnuMain.TabIndex = 6;
            this.mnuMain.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.Close,
            this.Save,
            this.toolStripSeparator1,
            this.Exit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(35, 20);
            this.File.Text = "File";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(152, 22);
            this.New.Text = "New";
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(152, 22);
            this.Open.Text = "Open";
            // 
            // Close
            // 
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(152, 22);
            this.Close.Text = "Close";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(152, 22);
            this.Save.Text = "Save";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(152, 22);
            this.Exit.Text = "Exit";
            // 
            // Tools
            // 
            this.Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageHardware,
            this.SetUpUserAccounts,
            this.ChangeDisplay});
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(44, 20);
            this.Tools.Text = "Tools";
            // 
            // ManageHardware
            // 
            this.ManageHardware.Name = "ManageHardware";
            this.ManageHardware.Size = new System.Drawing.Size(189, 22);
            this.ManageHardware.Text = "Manage Hardware";
            // 
            // SetUpUserAccounts
            // 
            this.SetUpUserAccounts.Name = "SetUpUserAccounts";
            this.SetUpUserAccounts.Size = new System.Drawing.Size(189, 22);
            this.SetUpUserAccounts.Text = "Set Up User Accounts";
            // 
            // ChangeDisplay
            // 
            this.ChangeDisplay.Name = "ChangeDisplay";
            this.ChangeDisplay.Size = new System.Drawing.Size(189, 22);
            this.ChangeDisplay.Text = "Change Display";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Contents,
            this.toolStripSeparator2,
            this.About});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(40, 20);
            this.Help.Text = "Help";
            // 
            // Contents
            // 
            this.Contents.Name = "Contents";
            this.Contents.Size = new System.Drawing.Size(152, 22);
            this.Contents.Text = "Contents";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(152, 22);
            this.About.Text = "About";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // DynamicDBMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 205);
            this.Controls.Add(this.cmdAdmin);
            this.Controls.Add(this.cmdUser);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "DynamicDBMenu";
            this.Text = "DynamicDBMenu";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdAdmin;
        internal System.Windows.Forms.Button cmdUser;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Tools;
        private System.Windows.Forms.ToolStripMenuItem ManageHardware;
        private System.Windows.Forms.ToolStripMenuItem SetUpUserAccounts;
        private System.Windows.Forms.ToolStripMenuItem ChangeDisplay;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem Contents;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem About;
    }
}