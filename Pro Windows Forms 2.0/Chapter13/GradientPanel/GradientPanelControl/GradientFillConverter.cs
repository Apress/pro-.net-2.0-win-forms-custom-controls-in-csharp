#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.ComponentModel;
using System.Globalization;
#endregion

namespace GradientPanelControl
{
    public class GradientFillConverter : ExpandableObjectConverter
    {
        private string ToString(object value)
        {
            GradientFill fill = (GradientFill)value;
            ColorConverter converter = new ColorConverter();
            return String.Format("{0}, {1}, {2}", converter.ConvertToString(fill.ColorA), converter.ConvertToString(fill.ColorB), fill.GradientFillStyle.ToString());
        }

        private GradientFill FromString(object value)
        {
            string[] values = ((string)value).Split(',');
            if (values.Length != 3)
                throw new ArgumentException("Could not convert the value");

            try
            {
                GradientFill gradient = new GradientFill();

                ColorConverter converter = new ColorConverter();
                
                gradient.ColorA = (Color)converter.ConvertFromString(values[0]);
                gradient.ColorB = (Color)converter.ConvertFromString(values[1]);

                // Convert the name of the enumerated value into the corresponding
                // enumerated value (which is actually an integer constant).
                gradient.GradientFillStyle = (LinearGradientMode)Enum.Parse(
                  typeof(LinearGradientMode), values[2], true);

                return gradient;
            }
            catch
            {
                throw new ArgumentException("Could not convert the value");
            }
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context,
          Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            else
            {
                return base.CanConvertFrom(context, sourceType);
            }
        }

        public override object ConvertFrom(ITypeDescriptorContext context,
          CultureInfo culture, object value)
        {
            if (value is string)
            {
                return FromString(value);
            }
            else
            {
                return base.ConvertFrom(context, culture, value);
            }
        }
        public override bool CanConvertTo(ITypeDescriptorContext context,
          Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return true;
            }
            else
            {
                return base.CanConvertTo(context, destinationType);
            }
        }

        public override object ConvertTo(ITypeDescriptorContext context,
          CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return ToString(value);
            }
            else
            {
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }

    }

}
