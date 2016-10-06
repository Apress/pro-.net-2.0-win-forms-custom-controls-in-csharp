using System;
using System.Collections;
using System.IO;

namespace DocumentView
{
	public class OrderItem
	{
		private int id;
		public int ID
		{
			get { return id; }
			set { id = value; }
		}
		
		public OrderItem(int id)
		{
			ID = id;
		}
	}

	public class Order : CollectionBase
	{
		public event EventHandler DocumentChanged;

		private string lastFilename = "[New Order]";
		public string LastFileName
		{
			get
			{
				return lastFilename;
			}
			set
			{
				lastFilename = value;
			}
		}

		public void Add(OrderItem item)
		{
			base.List.Add(item);
			OnDocumentChanged(new EventArgs());
		}

		public void Remove(int index)
		{
			// Check to see if there is an item at the supplied index.
			if (index > (this.Count - 1) || index < 0)
			{
				throw new System.IndexOutOfRangeException();
			}
			else
			{
				base.List.RemoveAt(index);
			}
			OnDocumentChanged(new EventArgs());
		}

		// Indexer.
		public OrderItem this[int index]
		{
			get { return (OrderItem)base.List[index]; }
			set { base.List[index] = value; }
		}

		protected void OnDocumentChanged(System.EventArgs e)
		{
			// Note that this currently occurs as items are added or removed,
			// but not when they are edited. To overcome this would require adding
			// an additional OrderItem change event.

			// Raise the DocumentChanged event.
			if (DocumentChanged != null)
			{
				DocumentChanged(this, e);
			}
		}


		public void Open(string filename)
		{
			using (FileStream fs = new FileStream(filename, FileMode.Open))
			{
				StreamReader r = new StreamReader(fs);

				do
				{
					this.Add(new OrderItem(int.Parse(r.ReadLine())));
				} while (r.Peek() != -1);

				r.Close();
			}

			// By placing this last we ensure that the file will not be updated
			// if a load error occurs.
			this.LastFileName = filename;
		}

		public void Save(string filename)
		{
			using (FileStream fs = new FileStream(filename, FileMode.Create))
			{
				StreamWriter w = new StreamWriter(fs);

				foreach (OrderItem item in this.List)
				{
					w.WriteLine(item.ID);
				}

				w.Close();
			}

			// Note: a real pricing program would probably store the price in the file
			// (required for orders) but update it to correspond with the current
			// price for the item when the file is opened.

			// By placing this last we ensure that the file will not be updated
			// if a save error occurs.
			this.LastFileName = filename;
		}

	}


	public class Product
	{
		private int id;
		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string description;
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		private decimal price;
		public decimal Price
		{
			get { return price; }
			set { price = value; }
		}

		public Product(int id, string name, string description, decimal price)
		{
			ID = id;
			Name = name;
			Description = description;
			Price = price;
		}
	}

}
