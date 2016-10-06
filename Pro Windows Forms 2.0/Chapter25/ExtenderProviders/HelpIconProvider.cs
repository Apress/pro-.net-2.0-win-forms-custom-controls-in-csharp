using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ExtenderProviders
{
    [ProvideProperty("HelpID", typeof(Control))]
    public partial class HelpIconProvider : Component, IExtenderProvider, ISupportInitialize
    {
        public HelpIconProvider()
        {
            InitializeComponent();
        }

        public HelpIconProvider(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool CanExtend(object extendee)
        {
            return (extendee is Control);
        }

        private string helpFile;
        public string HelpFile
        {
            get { return helpFile; }
            set { helpFile = value; }
        }

        // Store the context-senstive ID for each control.
        private Dictionary<Control, string> contextIDs =
          new Dictionary<Control, string>();

        // Store the dynamically inserted PictureBox controls.
        private Dictionary<Control, PictureBox> pictures =
          new Dictionary<Control, PictureBox>();

        public void SetHelpID(Control extendee, string value)
        {
            // A blank value string indicates the control is trying to unregister.
            if (value.Length == 0)
            {
                // Check if the item is registered.
                if (pictures.ContainsKey(extendee) && !DesignMode)
                {
                    // Perform this step only if the form is created.
                    if (extendee.Parent != null)
                        UnRegister(extendee);
                }
                // Stop maintaining the help ID.
                contextIDs.Remove(extendee);
            }
            else
            {
                // The user has supplied a value.
                // Check if the item is registered.
                if (!pictures.ContainsKey(extendee) && !DesignMode)
                {
                    if (extendee.Parent != null)
                        Register(extendee);
                }
                // Update or store the help ID.
                contextIDs[extendee] = value;
            }
        }

        public void BeginInit()
        { }
        public void EndInit()
        {
            // No design-time PictureBox controls are created.
            // Add them now.
            foreach (KeyValuePair<Control, string> item in contextIDs)
            {
                Register(item.Key);
            }
        }

        private void Register(Control control)
        {
            // Create new PictureBox.
            PictureBox pic = new PictureBox();
            pic.Image = Properties.Resources.help;
            pic.Size = new Size(16, 16);
            pic.Location = new Point(control.Right + 10, control.Top);
            // Register for DoubleClick event.
            pic.DoubleClick += new EventHandler(PicDoubleClick);
            // Store a reference to the help icon
            // So you can remove it later.
            pictures[control] = pic;
            // Add it to the form.
            control.Parent.Controls.Add(pic);
        }

        private void UnRegister(Control control)
        {
            // Detach event handler.
            pictures[control].DoubleClick -= new EventHandler(PicDoubleClick);
            // Remove the picture from the form.
            pictures[control].Dispose();
            control.Parent.Controls.Remove(pictures[control]);
            pictures.Remove(control);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose all the PictureBox controls.
                foreach (KeyValuePair<Control, PictureBox> item in pictures)
                {
                    item.Key.Dispose();
                }
            }

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public string GetHelpID(Control extendee)
        {
            if (contextIDs.ContainsKey(extendee))
            {
                return contextIDs[extendee];
            }
            else
            {
                return String.Empty;
            }
        }

        public void PicDoubleClick(object sender, EventArgs e)
        {
            // This message box is for debuggin purposes.
            // Trying to show a help file with non-existent topic
            // will not generate an error.
            MessageBox.Show("Help triggered.");

            // Find the related control.
            Control ctrl = null;
            foreach (KeyValuePair<Control, PictureBox> item in pictures)
            {
                if (item.Value == sender)
                {
                    ctrl = item.Key;
                    break;
                }
            }
            // Show the help.
            if (ctrl != null)
            {
                Help.ShowHelp(ctrl, helpFile, HelpNavigator.Topic,
                contextIDs[ctrl]);
            }
        }
    }
}
