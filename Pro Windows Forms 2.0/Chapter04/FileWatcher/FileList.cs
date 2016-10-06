using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileWatcher
{
    public partial class FileList : Form
    {
        public FileList()
        {
            InitializeComponent();
        }

 
        public void FillList(List<string> list)
        {
            lstFiles.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}