#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Design;

#endregion

namespace SimpleChart
{
    public class BarItemCollectionEditor : CollectionEditor
    {
        public BarItemCollectionEditor(Type type) : base(type)
        { }       
        
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            object returnObject = base.EditValue(context, provider, value);                      
            ((SimpleChart)Context.Instance).RebuildChart();
            return returnObject;
        }

        protected override object CreateInstance(Type itemType)
        {
            BarItem item = new BarItem("Enter Title Here", 0);
            return item;
        }


    }
}
