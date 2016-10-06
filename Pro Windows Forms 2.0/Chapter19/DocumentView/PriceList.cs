using System;

namespace DocumentView
{
	/// <summary>
	/// Summary description for PriceList.
	/// </summary>
	public class PriceList
	{
		public static Product GetItem(int ID)
			{
				switch (ID)
				{
					case 1:
						return new Product(ID, "Sample Product 1", "Sample Description 1", (decimal)14.99);
						
					case 2:
						return new Product(ID, "Sample Product 2", "Sample Description 2", (decimal)14.99);
						
					case 3:
						return new Product(ID, "Sample Product 3", "Sample Description 3", (decimal)14.99);
						
					default:
						throw new IndexOutOfRangeException("Not a valid product ID.");
				}
        
			}
        
	}
}
