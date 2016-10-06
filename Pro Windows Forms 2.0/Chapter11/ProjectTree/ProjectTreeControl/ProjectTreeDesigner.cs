using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;

namespace ProjectTreeControl
{
	public class ProjectTreeDesigner : ControlDesigner
	{
		protected override void PostFilterProperties(System.Collections.IDictionary
			properties)
		{
			base.PostFilterProperties(properties);
			properties.Remove("Nodes");
			properties.Remove("ImageList");
			properties.Remove("ImageIndex");
			properties.Remove("ImageKey");
		}

		protected override void PostFilterEvents(System.Collections.IDictionary events)
		{
			base.PostFilterEvents(events);
			events.Remove("AfterSelect");
		}
	}

}
