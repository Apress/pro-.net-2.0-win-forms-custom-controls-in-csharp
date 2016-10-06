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

namespace Microsoft.Samples
{
	class SampleCustomTypeDescriptor : ICustomTypeDescriptor
	{
		// Fields 
		Control _hostControl;
		PropertyDescriptorCollection _props;

		public SampleCustomTypeDescriptor(Control hostControl, PropertyDescriptorCollection props)
		{
			_hostControl = hostControl;
			_props = props;
		}

		public AttributeCollection GetAttributes()
		{
			return new AttributeCollection(null);
		}

		public String GetClassName()
		{
			return null;
		}

		public String GetComponentName()
		{
			return null;
		}

		public TypeConverter GetConverter()
		{
			return null;
		}

		public EventDescriptor GetDefaultEvent()
		{
			return null;
		}

		public PropertyDescriptor GetDefaultProperty()
		{
			return null;
		}

		public Object GetEditor(Type editorBaseType)
		{
			return null;
		}

		public EventDescriptorCollection GetEvents()
		{
			return new EventDescriptorCollection(null);
		}

		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return new EventDescriptorCollection(null);
		}

		public PropertyDescriptorCollection GetProperties()
		{
			return _props;
		}

		public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			return _props;
		}

		public Object GetPropertyOwner (PropertyDescriptor pd)
		{
			return _hostControl;
		}
	}
}
