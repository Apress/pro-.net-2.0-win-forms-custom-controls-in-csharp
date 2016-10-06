using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Design;
using System.Drawing.Design;
using System.ComponentModel.Design;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;

namespace Microsoft.Samples
{
	public class DesignModeDialogDesigner : ComponentDesigner
	{
		public override void Initialize(IComponent component) 
		{
			base.Initialize(component);

			ITypeDiscoveryService discoveryService = this.GetService(typeof(ITypeDiscoveryService)) as ITypeDiscoveryService;
			IDesignerHost host = this.GetService(typeof(IDesignerHost)) as IDesignerHost;

			if (host != null) 
			{
				PropertyDescriptor hostFormProp = TypeDescriptor.GetProperties(this.Component)["HostForm"];
				Form hostForm = host.RootComponent as Form;
				if ((hostFormProp != null) && (hostForm != null))
				{
					hostFormProp.SetValue(this.Component, hostForm);
				}
			}
		}


		public override void InitializeNewComponent(IDictionary defaultValues)
		{
			PropertyDescriptor propertiesToDesignProp = TypeDescriptor.GetProperties(this.Component)["PropertiesToDesign"];
			Collection<string> _propertiesToDesign = propertiesToDesignProp.GetValue(this.Component) as Collection<string>;

			// Add some defaults
			if (_propertiesToDesign.Count == 0)
			{
				string[] props = new string[] { "Items", "AutoSize", "Size", "Text", "Font", "Location", "ForeColor", "BackColor", "Anchor", "Dock", "ClientSize" };
				foreach (string s in props)
				{
					_propertiesToDesign.Add(s);
				}
			}

		}

	}
}
