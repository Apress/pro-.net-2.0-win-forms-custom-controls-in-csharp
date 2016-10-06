using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TreeViewDataBinding
{
	public class StoreDB
	{
		public DataTable GetCategories()
		{
			string connectionString = Properties.Settings.Default.Store;
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand("GetProducts", con);
			cmd.CommandType = CommandType.StoredProcedure;
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataSet ds = new DataSet();
			adapter.Fill(ds, Tables.Product);
			cmd.CommandText = "GetCategories";
			adapter.Fill(ds, Tables.Category);

			// Set up a relation between these tables (optional).
			DataRelation relCategoryProduct = new DataRelation("CategoryProduct",
			  ds.Tables[Tables.Category].Columns[CategoryField.ID],
			  ds.Tables[Tables.Product].Columns[ProductField.CategoryID]);
			ds.Relations.Add(relCategoryProduct);
			return ds.Tables[Tables.Category];
		}

		public static class Tables
		{
			public const string Product = "Products";
			public const string Category = "Categories";
		}

		public static class ProductField
		{
			public const string Name = "ModelName";
			public const string Description = "Description";
			public const string CategoryID = "CategoryID";
		}

		public static class CategoryField
		{
			public const string Name = "CategoryName";
			public const string ID = "CategoryID";
		}

		public DataRow[] GetProductsInCategory(DataRow rowParent)
		{
			DataRelation relCategoryProduct = rowParent.Table.DataSet.Relations[0];
			return rowParent.GetChildRows(relCategoryProduct);
		}

		public string GetDisplayText(DataRow row)
		{
			string text = "";

			switch (row.Table.TableName)
			{
				case Tables.Product:
					text = "ID: " + row[0] + "\n";
					text += "Name: " + row[ProductField.Name] + "\n\n";
					text += row[ProductField.Description];
					break;
			}
			return text;
		}
	}

}
