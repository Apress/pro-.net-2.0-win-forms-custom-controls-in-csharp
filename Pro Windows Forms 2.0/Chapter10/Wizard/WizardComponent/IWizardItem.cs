#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

#endregion

namespace WizardComponent
{
    public interface IWizardItem
    {
        string HeaderTitle
        {
            get;
        }

        Dictionary<string, string> GetValues();
        void ApplyValues(Dictionary<string, string> values);
    }
}
