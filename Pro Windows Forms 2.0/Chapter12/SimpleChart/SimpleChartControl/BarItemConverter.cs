using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Globalization;
using System.ComponentModel.Design.Serialization;
using System.Reflection;

namespace SimpleChart
{
    public class BarItemConverter : ExpandableObjectConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type t)
        {
            if (t == typeof(string))
                return true;
            else
                return base.CanConvertFrom(context, t);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destType)
        {
            if (destType == typeof(InstanceDescriptor) || destType == typeof(string))
                return true;
            else
                return base.CanConvertTo(context, destType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo info, object value)
        {
            if (value is string)
            {
                try
                {
                    string[] elements = ((string)value).Split(',');
                    return new BarItem(elements[0], float.Parse(elements[1]));
                }
                catch
                {
                    throw new ArgumentException("Could not convert the value");
                }
            }
            return base.ConvertFrom(context, info, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo info, object value, Type destType)
        {
            if (destType == typeof(string))
            {
                BarItem item = (BarItem)value;
                return String.Format("{0}, {1}", item.ShortForm, item.Value);
            }
            else if (destType == typeof(InstanceDescriptor))
            {
                BarItem item = (BarItem)value;
                ConstructorInfo ctor =
                  typeof(BarItem).GetConstructor(
                  new Type[] { typeof(string), typeof(float) });

                return new InstanceDescriptor(ctor,
                   new object[] { item.ShortForm, item.Value });
            }
            else
            {
                return base.ConvertTo(context, info, value, destType);
            }
        }


    }
}
