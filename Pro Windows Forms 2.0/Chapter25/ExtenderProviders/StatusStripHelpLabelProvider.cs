using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExtenderProviders
{
    [ProvideProperty("HelpText", typeof(ToolStripItem))]
    public class StatusStripHelpLabel : ToolStripStatusLabel, IExtenderProvider
    {
        // The collection for tracking the help text information.
        private Dictionary<ToolStripItem, string> helpText =
          new Dictionary<ToolStripItem, string>();

        public bool CanExtend(object extendee)
        {
            return (extendee is ToolStripItem);
        }
                
        public void SetHelpText(ToolStripItem extendee, string value)
        {
            // A blank value string indicates the control is trying to unregister.
            if (value.Length == 0)
            {
                // Check if the item is registered.
                if (!helpText.ContainsKey(extendee) && !DesignMode)
                {
                    // Unregister.
                    extendee.MouseEnter -= new EventHandler(MenuSelect);
                    extendee.MouseLeave -= new EventHandler(MenuClear);
                }
                helpText.Remove(extendee);
            }
            else
            {
                // The user has supplied help text.
                // Check if the item is registered.
                if (!helpText.ContainsKey(extendee) && !DesignMode)
                {
                    // It hasn't been registered yet. Register it now.
                    extendee.MouseEnter += new EventHandler(MenuSelect);
                    extendee.MouseLeave += new EventHandler(MenuClear);
                }
                // Either way, update the help text.
                helpText[extendee] = value;
            }
        }

        [DisplayName("HelpText")]
        [Category("Behavior")]
        [Description("This text appears in the linked StatusStripHelpLabel.")]
        public string GetHelpText(ToolStripItem extendee)
        {
            if (helpText.ContainsKey(extendee))
            {
                return helpText[extendee];
            }
            else
            {
                return string.Empty;
            }
        }

        private void MenuSelect(object sender, System.EventArgs e)
        {
            base.Text = helpText[(ToolStripMenuItem)sender];
        }

        private void MenuClear(object sender, System.EventArgs e)
        {
            base.Text = string.Empty;
        }

    }
}
