using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WizardComponent;

namespace WizardComponentTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            items.Add(new NameStep());
            items.Add(new RegistrationStep());
        }

        List<IWizardItem> items = new List<IWizardItem>();

        private void button1_Click(object sender, EventArgs e)
        {
            Wizard wizard = new Wizard(items);
            wizard.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (IWizardItem item in items)
            {
                string text = "";
                foreach (KeyValuePair<string,string> setting in item.GetValues())
                {
                    text += String.Format("Key: {0}, Value: {1}\n", setting.Key, setting.Value);
                }
                MessageBox.Show(text);
            }
        }
                
        
    }
}