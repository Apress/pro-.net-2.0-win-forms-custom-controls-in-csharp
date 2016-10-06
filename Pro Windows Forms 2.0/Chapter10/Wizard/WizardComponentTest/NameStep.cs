#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using WizardComponent;
#endregion

namespace WizardComponentTest
{
    public partial class NameStep : UserControl, IWizardItem 
    {
        public string HeaderTitle
        {
            get { return "Please enter your first and last name."; }
        }

        Dictionary<string, string> values = new Dictionary<string, string>();

        public Dictionary<string, string> GetValues()
        {
            values.Clear();
            values.Add("FirstName", txtFirstName.Text);
			values.Add("LastName", txtLastName.Text);
            return values;
        }

        public void ApplyValues(Dictionary<string, string> values)
        {
            this.values = values;
            txtFirstName.Text = values["FirstName"];
			txtFirstName.Text = values["LastName"];
        }

        public NameStep()
        {
            InitializeComponent();
        }

        private void Step1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
