#region Using directives

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

#endregion

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace System.Windows.Forms.Samples.RSS
{
	[Serializable()]
	public class RssLink
	{
		private string	_title;
		private string	_url;
        private bool    _showImage = true;
		const string	DATA_FILE = @"..\..\Data\links.dat";

		public RssLink()
		{
		}

		public RssLink(string title, string url)
		{
			this.Title = title;
			this.URL = url;
		}

		#region Public API
		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		public string URL
		{
			get { return _url; }
			set { _url = value.Trim(); }
		}

        public bool ShowImage
        {
            get { return _showImage; }
            set { _showImage = value; }
        }
		#endregion

		#region Static API
		private static SortableBindingList<RssLink>	_links;

		public static SortableBindingList<RssLink> Links
		{
			get
			{
				if (null == _links)
				{
					_links = Load();
				}

				return _links;
			}
		}

		public static int FindLink(string url)
		{
			int		found=-1;
			string	trim = url.Trim();

			for (int idx = 0; idx < Links.Count; idx++)
			{
				if (Links[idx].URL == trim)
				{
					found = idx;
					break;
				}
			}

			return found;
		}

		public static void Add(string title, string url)
		{
			int		idx = FindLink(url);

			if (idx < 0)
			{
				// New item
				Links.Add(new RssLink(title, url));
			}
			else
			{
				// Update existing
				Links[idx].URL = url;
				Links[idx].Title = title;
			}

			// Re-save
			Save();
		}

		private static SortableBindingList<RssLink> Load()
		{
			// Use default data file
            return Load(DATA_FILE);
		}

		private static SortableBindingList<RssLink> Load(string file)
		{
			FileStream				fs = null;
			BinaryFormatter			bf = new BinaryFormatter();
			SortableBindingList<RssLink>	list = null;

			try
			{
				fs = new FileStream(file, FileMode.Open);
				list = bf.Deserialize(fs) as SortableBindingList<RssLink>;

				if (null == list)
				{
					list = new SortableBindingList<RssLink>();
				}
			}
			catch (Exception)
			{
				list = new SortableBindingList<RssLink>();
			}
			finally
			{
				if (null != fs)
				{
					fs.Close();
				}
			}

			return list;
		}

		public static void Save()
		{
			// Use default data file
			Save(DATA_FILE, Links);
		}

		private static void Save(SortableBindingList<RssLink> links)
		{
			// Use default data file
			Save(DATA_FILE, links);
		}

		private static void Save(string file, SortableBindingList<RssLink> links)
		{
			BinaryFormatter bf = new BinaryFormatter();

			// Create File to Searilze to
			FileStream fs = new FileStream(file, FileMode.Create);

			try
			{
				bf.Serialize(fs, links);
			}
			finally
			{
				fs.Close();
			}
		}
		#endregion
	}

	#region SortableBindingList
	[Serializable()]
	public class SortableBindingList<T> : BindingList<T>
	{
		private bool				_isSorted;
		private	ListSortDirection	_dir = ListSortDirection.Ascending;

		[NonSerialized()]
		private PropertyDescriptor _sort = null;

		public void Sort()
		{
			ApplySortCore(_sort, _dir);
		}

		public void Sort(string property)
		{
			// Get the 
			_sort = FindPropertyDescriptor(property);

			// Sort
			ApplySortCore(_sort, _dir);
		}

		public void Sort(string property, ListSortDirection direction)
		{
			// Get the sort property
			_sort = FindPropertyDescriptor(property);
			_dir = direction;

			// Sort
			ApplySortCore(_sort, _dir);
		}

		private PropertyDescriptor FindPropertyDescriptor(string property)
		{
			PropertyDescriptorCollection	pdc = TypeDescriptor.GetProperties(typeof(T));
			PropertyDescriptor				prop=null;

			if (null != pdc)
			{
				prop = pdc.Find(property, true);
			}

			return prop;
		}

		protected override bool SupportsSortingCore
		{
			get { return true; }
		}

		protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
		{
			List<T> items = this.Items as List<T>;

			if ((null != items) && (null != property))
			{
				PropertyComparer<T> pc = new PropertyComparer<T>(property, direction);
				items.Sort(pc);

				// Set sorted
				_isSorted = true;
			}
			else
			{
				// Set sorted
				_isSorted = false;
			}
		}

		protected override bool IsSortedCore
		{
			get { return _isSorted; }
		}

		protected override void RemoveSortCore()
		{
			_isSorted = false;
		}
	}
	#endregion

	#region PropertyComparar
	public class PropertyComparer<T> : System.Collections.Generic.IComparer<T>
	{

		// The following code contains code implemented by Rockford Lhotka:
		// http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dnadvnet/html/vbnet01272004.asp

		private PropertyDescriptor _property;
		private ListSortDirection _direction;

		public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
		{
			_property = property;
			_direction = direction;
		}

		public int Compare(T xWord, T yWord)
		{
			// Get property values
			object xValue = GetPropertyValue(xWord, _property.Name);
			object yValue = GetPropertyValue(yWord, _property.Name);

			// Determine sort order
			if (_direction == ListSortDirection.Ascending)
			{
				return CompareAscending(xValue, yValue);
			}
			else
			{
				return CompareDescending(xValue, yValue);
			}
		}

		public bool Equals(T xWord, T yWord)
		{
			return xWord.Equals(yWord);
		}

		public int GetHashCode(T obj)
		{
			return obj.GetHashCode();
		}

		// Compare two property values of any type
		private int CompareAscending(object xValue, object yValue)
		{
			int result;

			// If values implement IComparer
			if (xValue is IComparable)
			{
				result = ((IComparable)xValue).CompareTo(yValue);
			}
			// If values don't implement IComparer but are equivalent
			else if (xValue.Equals(yValue))
			{
				result = 0;
			}
			// Values don't implement IComparer and are not equivalent, so compare as string values
			else result = xValue.ToString().CompareTo(yValue.ToString());

			// Return result
			return result;
		}

		private int CompareDescending(object xValue, object yValue)
		{
			// Return result adjusted for ascending or descending sort order ie
			// multiplied by 1 for ascending or -1 for descending
			return CompareAscending(xValue, yValue) * -1;
		}

		private object GetPropertyValue(T value, string property)
		{
			// Get property
			System.Reflection.PropertyInfo propertyInfo = value.GetType().GetProperty(property);

			// Return value
			return propertyInfo.GetValue(value, null);
		}
	}
	#endregion
}
