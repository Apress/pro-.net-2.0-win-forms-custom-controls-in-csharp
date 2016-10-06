using System;
using System.Collections.Generic;
using System.Text;

namespace BindingToCollections
{
	public class Product
	{
		private string modelNumber;
		public string ModelNumber
		{
			get { return modelNumber; }
			set { modelNumber = value; }
		}

		private string modelName;
		public string ModelName
		{
			get { return modelName; }
			set { modelName = value; }
		}

		private decimal unitCost;
		public decimal UnitCost
		{
			get { return unitCost; }
			set { unitCost = value;	}
		}

		private string description;
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		public Product(string modelNumber, string modelName,
			decimal unitCost, string description)
		{
			ModelNumber = modelNumber;
			ModelName = modelName;
			UnitCost = unitCost;
			Description = description;
		}

		public override string ToString()
		{
			return ModelName + " (" + ModelNumber + ")";
		}
	}
}
