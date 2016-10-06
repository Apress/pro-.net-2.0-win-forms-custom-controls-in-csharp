using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DynamicLayout
{
    public partial class FormsFromFile : Form
    {
        public FormsFromFile()
        {
            InitializeComponent();
        }

        private void FormsFromFile_Load(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog.FileName;
                SurveyDeserializer surveyReader = new SurveyDeserializer(openFileDialog.FileName, tableLayoutPanel1);
                tableLayoutPanel1.SuspendLayout();
                surveyReader.LoadForm();
                tableLayoutPanel1.ResumeLayout();
            }
        }

        
    }
}