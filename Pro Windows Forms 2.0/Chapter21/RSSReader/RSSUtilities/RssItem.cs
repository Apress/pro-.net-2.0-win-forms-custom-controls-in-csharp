#region Using directives

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

#endregion

namespace System.Windows.Forms.Samples.RSS
{
	public class RssItem
	{
		private Dictionary<string, string> _attributes;

		public RssItem()
		{
			_attributes = new Dictionary<string, string>();
		}

		#region Public Properties
		public string Title
		{
			get { return GetValue("title"); }
		}

		public string Link
		{
			get { return GetValue("link"); }
		}

		public string Description
		{
			get { return GetValue("description"); }
		}

		[Browsable(false)]
		public string this[string key]
		{
			get { return GetValue(key); }
		}

		[Browsable(false)]
		public Dictionary<string, string> Attributes
		{
			get { return _attributes; }
		}
		#endregion

		#region Public Methods
		public void SetAttribute(string name, string val)
		{
			string		localName = name.ToLower();

			// Look for dups (ignore dups for now)
			if (!Attributes.ContainsKey(localName))
			{
				Attributes.Add(localName, val.Trim());
			}
		}
		#endregion

		#region Private Implementation
		protected string GetValue(string name)
		{
			return (_attributes.ContainsKey(name) ? _attributes[name] : null);
		}
		#endregion
	}
}
