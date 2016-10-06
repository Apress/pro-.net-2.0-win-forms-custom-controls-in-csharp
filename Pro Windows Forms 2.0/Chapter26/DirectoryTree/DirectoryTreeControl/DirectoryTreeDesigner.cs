using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;
using System.ComponentModel;
using System.Drawing.Design;

namespace DirectoryTreeControl
{
	public class DirectoryTreeDesigner : ControlDesigner
	{
		private DesignerVerbCollection verbs = new DesignerVerbCollection();

        private DesignerVerb verbSetDrive;

		public DirectoryTreeDesigner()
		{
            // Configure the designer verb collection.
            // Add the Set Drive verb that calls up the form.
            verbSetDrive = new DesignerVerb("Set Drive",
                new EventHandler(OnVerb));
            verbs.Add(verbSetDrive);

            // Add a verb for quickly setting each possible drive value
            // (for demonstration purposes).
            string[] drives = System.IO.Directory.GetLogicalDrives();

            foreach (string drive in drives)
            {
                verbs.Add(new DesignerVerb("Set Drive " + drive,
                  new EventHandler(OnVerb)));
            }
		}

		private IComponentChangeService changeService;
		public override void Initialize(IComponent component)
		{
			base.Initialize(component);
			
			// Update your designer verb whenever ComponentChanged event occurs. 
			changeService =
			  (IComponentChangeService)GetService(typeof(IComponentChangeService));
			if (changeService != null)
				changeService.ComponentChanged +=
				  new ComponentChangedEventHandler(ComponentChanged);
		}

		protected override void Dispose(bool disposing)
		{			 
			if (changeService != null)
				changeService.ComponentChanged -=
				  new ComponentChangedEventHandler(ComponentChanged);
		}

		private void ComponentChanged(object sender, ComponentChangedEventArgs e)
		{
			DirectoryTree tree = (DirectoryTree)this.Control;
			
			if (tree != null)
			{
				foreach (DesignerVerb verb in verbs)
				{
                    if (verb != verbSetDrive)
                    {
                        if (verb.Text[10] == tree.Drive)
                            verb.Enabled = false;
                        else
                            verb.Enabled = true;
                    }
				}
			}
		} 

		public override DesignerVerbCollection Verbs
		{
			get
			{
				return verbs;
			}
		}

		protected void OnVerb(object sender, EventArgs e)
		{
            char oldValue = ((DirectoryTree)this.Control).Drive;
            char newValue;

            if (sender == verbSetDrive)
            {
                // Show the form.
                using (SelectDrive frm = new SelectDrive())
                {
                    frm.DriveSelection = oldValue;

                    // Exit in case Cancel is clicked.
                    if (frm.ShowDialog() != DialogResult.OK) return;

                    // Get the result.
                    newValue = frm.DriveSelection;
                }                
            }
            else
            {
                // Retrieve the selected drive.
                newValue = ((DesignerVerb)sender).Text[10];
            }

            // Adjust the associated control.
            ((DirectoryTree)this.Control).Drive = newValue;

            // Notify the IDE that the Drive property has changed.
            PropertyDescriptorCollection properties;
            properties = TypeDescriptor.GetProperties(typeof(DirectoryTree));
            PropertyDescriptor changedProperty = properties.Find("Drive", false);
            this.RaiseComponentChanged(changedProperty, oldValue, newValue);
		}

		protected override void PostFilterProperties(System.Collections.IDictionary 
			properties)
		{
			properties.Remove("Nodes");
		}
	}
}
