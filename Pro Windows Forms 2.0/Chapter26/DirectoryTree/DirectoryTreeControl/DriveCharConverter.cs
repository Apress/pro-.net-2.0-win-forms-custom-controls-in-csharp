using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections;

namespace DirectoryTreeControl
{
	public class DriveCharConverter : CharConverter
	{
		
		private static TypeConverter.StandardValuesCollection svc;

		public override System.ComponentModel.TypeConverter.StandardValuesCollection
	GetStandardValues(ITypeDescriptorContext context)
		{
			if (svc == null)
			{				
				ArrayList drives = new ArrayList();
				foreach (string drive in System.IO.Directory.GetLogicalDrives())
				{
					drives.Add(drive[0]);
					}
				svc = new TypeConverter.StandardValuesCollection(drives);
			}
	

			return svc;
		}

		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{ return false; }

		public override bool GetStandardValuesSupported(
		  ITypeDescriptorContext context)
		{ return true; }

		
	}
}
