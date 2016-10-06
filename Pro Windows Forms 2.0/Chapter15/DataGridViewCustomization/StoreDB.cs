using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataGridViewCustomization
{
	public class StoreDB
	{
		public DataTable GetProducts()
		{
			string connectionString = Properties.Settings.Default.Store;
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand("GetProducts", con);
			cmd.CommandType = CommandType.StoredProcedure;
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataSet ds = new DataSet();
			// Get read-only column info.
			adapter.FillSchema(ds, SchemaType.Mapped, "Products");
			// Fill the table.
			adapter.Fill(ds, "Products");
			return ds.Tables[0];
		}

		public DataSet GetCategoriesAndProducts()
		{
			string connectionString = Properties.Settings.Default.Store;
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand("GetProducts", con);
			cmd.CommandType = CommandType.StoredProcedure;
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataSet ds = new DataSet();
			adapter.Fill(ds, "Products");
			cmd.CommandText = "GetCategories";
			adapter.Fill(ds, "Categories");

			ds.Relations.Add("Cat_Prod",
				ds.Tables["Categories"].Columns["CategoryID"],
				ds.Tables["Products"].Columns["CategoryID"]);
			return ds;
		}

		public string ValidateProduct(DataRow row)
		{
			string errors = "";

			if (((decimal)row["UnitCost"]) <= 0)
			{
				errors += "* UnitCost value too low\n";
			}
			if (row["ModelNumber"].ToString() == "")
			{
				errors += "* You must specify a ModelNumber\n";
			}
			if (row["ModelName"].ToString() == "")
			{
				errors += "* You must specify a ModelName\n";
			}
			return errors;
		}

	}

}
