using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace FileWatcher
{
    public partial class FileSystemTray : Component
    {
        public FileSystemTray()
        {
            Initialize();
        }

        public FileSystemTray(IContainer container)
        {
            container.Add(this);
            
            Initialize();
        }

        public void Initialize()
        {
            InitializeComponent();
            cmdExit.Click += new EventHandler(cmdExit_Click);
            cmdShowFiles.Click += new EventHandler(cmdShowFiles_Click);
        }

        private List<string> newFiles = new List<string>();

        private void fileSystemWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            newFiles.Add(e.Name);
        }

        private void cmdExit_Click(object sender, System.EventArgs e)
        {
            // Make sure the icon disappears promptly.
            this.Dispose();

            Application.Exit();
        }

        private void cmdShowFiles_Click(object sender, System.EventArgs e)
        {
            FileList frmFileList = new FileList();
            frmFileList.FillList(newFiles);
            frmFileList.Show();
        }
    }
}
