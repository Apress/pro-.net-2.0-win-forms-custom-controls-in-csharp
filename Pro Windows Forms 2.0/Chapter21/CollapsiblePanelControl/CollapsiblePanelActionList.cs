using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Microsoft.Samples
{
	/// <summary>
	/// Summary description for MyControlActionList.
	/// </summary>
	public class CollapsiblePanelActionList //: System.ComponentModel.Design.DesignerActionList
	{
		CollapsiblePanel control;
		ISelectionService selectionService;

		//public CollapsiblePanelActionList(CollapsiblePanel control, ISelectionService selectionService)
		//{
		//    this.control = control;
		//    this.selectionService = selectionService;
		//}

		// Proeprties
		public string Text
		{
			get
			{
				return control.Text;
			}
			set
			{
				// Setting through property descriptor to enable undo support
				PropertyDescriptor prop = TypeDescriptor.GetProperties(control)["Text"];
				prop.SetValue(control, value);
			}
		}

		// Methods
		public void CollapsePanel()
		{
			// Setting through property descriptor to enable undo support
			PropertyDescriptor prop = TypeDescriptor.GetProperties(control)["Collapsed"];
			prop.SetValue(control, true);
		}

		public void ExpandPanel()
		{
			// Setting through property descriptor to enable undo support
			PropertyDescriptor prop = TypeDescriptor.GetProperties(control)["Collapsed"];
			prop.SetValue(control, false);
		}

		//public override DesignerActionItem[] GetSortedActionItems()
		//{
		//    DesignerActionItem[] items = new DesignerActionItem[4];

		//    items[0] = new DesignerActionHeaderItem("Behavior", "Behavior");
		//    items[1] = new DesignerActionPropertyItem("Text", "Text", "Behavior", "Sets the text of the control");
		//    items[2] = new DesignerActionHeaderItem("Appearance", "Appearance");

		//    if (control.Collapsed)
		//    {
		//        items[3] = new DesignerActionMethodItem(this, "ExpandPanel", "Expand Panel", "Appearance", "Expands the panel", true);
		//    }
		//    else
		//    {
		//        items[3] = new DesignerActionMethodItem(this, "CollapsePanel", "Collapse Panel", "Appearance", "Collapses the panel", true);
		//    }

		//    return items;
		//}

	}
}
