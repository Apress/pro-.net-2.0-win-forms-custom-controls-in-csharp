using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace BindingToCollections
{
	public class StoreDB
	{
		public ProductList GetProducts()
		{
			string connectionString = Properties.Settings.Default.Store;
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand("GetProducts", con);
			cmd.CommandType = CommandType.StoredProcedure;

			ProductList products = new ProductList();
			try
			{
				con.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					// Create a Product object that wraps the 
					// current record.
					Product product = new Product((string)reader["ModelNumber"],
						(string)reader["ModelName"], (decimal)reader["UnitCost"],
						(string)reader["Description"]);

					// Add to collection
					products.Add(product);
				}
			}
			finally
			{
				con.Close();
			}

			return products;
		}
	}

}
