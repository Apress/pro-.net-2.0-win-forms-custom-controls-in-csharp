#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

#endregion

namespace OwnerDrawList
{
    public class FormattedListItemWrapper
    {
        private object item;
        public object Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }

        private Color foreColor;
        public Color ForeColor
        {
            get
            {
                return foreColor;
            }
            set
            {
                foreColor = value;
            }
        }

        private Color backColor;
        public Color BackColor
        {
            get
            {
                return backColor;
            }
            set
            {
                backColor = value;
            }
        }

        private Font font;
        public Font Font
        {
            get
            {
                return font;
            }
            set
            {
                font = value;
            }
        }

        public override string ToString()
        {
            if (Item == null)
            {
                return null;
            }
            else
            {
                return Item.ToString();
            }
        }

        public FormattedListItemWrapper(object item)
        {
            Item = item;
        }

        public FormattedListItemWrapper(object item, Font font) : this(item)
        {
            Font = font;
        }

        public FormattedListItemWrapper(object item, Font font,
            Color foreColor, Color backColor) : this(item, font)
        {
            ForeColor = foreColor;
            BackColor = backColor;
        }
    }
}
