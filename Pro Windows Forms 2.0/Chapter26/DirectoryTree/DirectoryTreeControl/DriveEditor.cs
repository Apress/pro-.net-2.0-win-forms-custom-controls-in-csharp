using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;
using System.ComponentModel;
using System.Drawing.Design;

namespace DirectoryTreeControl
{
	public class DriveEditor : UITypeEditor
	{
		public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(
			System.ComponentModel.ITypeDescriptorContext context)
		{
			// We will use a window for property editing.
			return UITypeEditorEditStyle.Modal;
			
		}

		public override object EditValue(
			System.ComponentModel.ITypeDescriptorContext context,
			System.IServiceProvider provider, object value)
		{
			SelectDrive frm = new SelectDrive();

			// Set current drive in window.
			frm.DriveSelection = (char)value;
			frm.ShowDialog();

			// Return the new value.
			return frm.DriveSelection;
		}

		public override bool GetPaintValueSupported(
			System.ComponentModel.ITypeDescriptorContext context)
		{
			// No special thumbnail will be shown for the grid.
			return false;
		}

	}

}
