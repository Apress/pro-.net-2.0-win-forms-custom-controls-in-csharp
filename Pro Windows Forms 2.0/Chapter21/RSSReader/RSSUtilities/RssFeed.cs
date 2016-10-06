#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;

using System.Data;
using System.Xml;
using System.Diagnostics;

#endregion

namespace System.Windows.Forms.Samples.RSS
{
	public class RssFeed : RssItem
	{
		private List<RssItem>		_items;
		private string				_url=null;
		private Image				_image=null;
		private RssItem				_imageItem=null;

		// Constants
		const string			CHANNEL_ELEMENT = "channel";
		const string			IMAGE_ELEMENT = "image";
		const string			ITEM_ELEMENT = "item";

		public RssFeed()
		{
		}

		#region Public Properties
		public void Load(string url)
		{
			// Load URL
			_url = url;

			// Reset
			_imageItem = null;
			_items = null;

			// Load
			GetFeedData(_url);
		}

		public string URL
		{
			get { return _url; }
		}

		public Image Image
		{
			get
			{
				if ((null == _image) && (null != _imageItem))
				{
					_image = GetImage(_imageItem["url"]);
				}

				return _image;
			}
		}

		public List<RssItem> Items
		{
			get
			{
				if (null == _items)
				{
					_items = new List<RssItem>();
				}

				return _items;
			}
		}
		#endregion

		#region Private Implementation
		private Image GetImage(string url)
		{
			Image	image = null;

			if (!String.IsNullOrEmpty(url))
			{
				try
				{
					WebRequest		req = WebRequest.Create(url);
					WebResponse		resp = req.GetResponse();

					image = Image.FromStream(resp.GetResponseStream());
				}
				catch (Exception ex)
				{
					Debug.WriteLine("Unable to get image from: " + url + " (" + ex.Message + ")");
				}
			}

			return image;
		}

		private void GetFeedData(string url)
		{
			XmlTextReader		reader = new XmlTextReader(url);
			string				localName;
			bool				channelFound=false;

			while (reader.Read())
			{
				XmlNodeType nt = reader.NodeType;

				if (reader.NodeType == XmlNodeType.Element)
				{
					// Set name
					localName = reader.LocalName.ToLower();

					if (!channelFound)
					{
						if (localName == CHANNEL_ELEMENT)
						{
							// Found main body of the feed
							channelFound = true;
						}
					}
					else if (localName == ITEM_ELEMENT)
					{
						// Read an item
						this.Items.Add(ReadItem(reader, ITEM_ELEMENT));
					}
					else if (localName == IMAGE_ELEMENT)
					{
						// Read image
						_imageItem = ReadItem(reader, IMAGE_ELEMENT);
					}
					else
					{
						// Move to the Text content
						if (XmlNodeType.Element == reader.MoveToContent())
						{
							// Read the Text content
							string	content = reader.ReadString();

							// Make sure there are no nested elements
							if (XmlNodeType.EndElement == reader.NodeType)
							{
								// If not, then add
								this.SetAttribute(reader.LocalName, content);
							}
							else
							{
								// Strange - a nested element - we should ignore
							}
						}
					}
				}
			}
		}

		private RssItem ReadItem(XmlTextReader reader, string name)
		{
			bool	endFound = false;
			RssItem item = new RssItem();

			while (!endFound && reader.Read())
			{
				if ((reader.NodeType == XmlNodeType.EndElement) && (reader.LocalName.ToLower() == name))
				{
					endFound = true;
				}
				else if (reader.NodeType == XmlNodeType.Element)
				{
					// Get Local name
					item.SetAttribute(reader.LocalName, reader.ReadString());
				}
			}

			// Return item
			return item;
		}
		#endregion
	}
}
