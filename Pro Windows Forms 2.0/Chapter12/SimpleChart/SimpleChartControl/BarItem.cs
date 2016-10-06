using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Design;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.ComponentModel.Design.Serialization;
using System.Collections;

namespace SimpleChart
{
	/// <summary>
	/// Summary description for BarItem.
	/// </summary>
	/// 
    [Serializable()]
 	[TypeConverter(typeof(BarItemConverter))]
	public class BarItem
	{
		private string shortForm;
		public string ShortForm
		{
			get { return shortForm; }
			set { shortForm = value; }
		}

		private float barValue;
		public float Value
		{
			get { return barValue; }
			set { barValue = value; }
		}

		public BarItem()
		{
		}
		public BarItem(string shortForm, float value)
		{
			this.ShortForm = shortForm;
			this.Value = value;
		}
	}
    
		

}
