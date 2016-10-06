#region Using directives

using System;
using System.Collections;
using System.Text;
using System.ComponentModel.Design;
using System.Drawing.Design;


#endregion

namespace SimpleChart
{
	[System.ComponentModel.Editor(typeof(BarItemCollectionEditor),
	 typeof(System.Drawing.Design.UITypeEditor))]
    public class BarItemCollection : CollectionBase
    {
        public void Add(BarItem item)
        {
            this.List.Add(item);
        }

        public void Remove(int index)
        {
            // Check to see if there is an item at the supplied index.
            if ((index > Count - 1) || (index < 0))
            {
                throw new System.IndexOutOfRangeException();
            }
            else
            {
                this.List.RemoveAt(index);
            }
        }

        public BarItem this[int i]
        {
            get {return (BarItem)this.List[i]; }
		    set {this.List[i] = value;}
        }
    }

}
