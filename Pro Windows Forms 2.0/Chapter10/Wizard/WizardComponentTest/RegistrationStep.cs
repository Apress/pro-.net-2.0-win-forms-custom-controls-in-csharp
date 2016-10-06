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
    public partial class RegistrationStep : UserControl, IWizardItem
    {
        public string HeaderTitle
        {
            get { return "Select a registration method"; }
        }

        Dictionary<string, string> values = new Dictionary<string, string>();

        public Dictionary<string, string> GetValues()
        {
            values.Clear();
			foreach (RadioButton opt in Controls)
			{
				if (opt.Checked)
				{
					values.Add(opt.Name, "True");
					break;
				}
			}
            return values;
        }

        public void ApplyValues(Dictionary<string, string> values)
        {
            this.values = values;
			foreach (RadioButton opt in Controls)
			{
				if (values[opt.Name] != null)
				{
					opt.Checked = true;
					break;
				}
			}
        }

        public RegistrationStep()
        {
            InitializeComponent();
        }
    }
}
