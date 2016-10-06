using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace AutomaticObjectBinding
{
	public class ProductList : BindingList<Product>
	{
		public ProductList()
		{
			base.AllowNew = true;
		}

		protected override object AddNewCore()
		{
			Product product = new Product(Guid.NewGuid().ToString(), "[ModelName]", 0, "[Description]");
			base.Items.Add(product);
			return product;
		}
	}
}
