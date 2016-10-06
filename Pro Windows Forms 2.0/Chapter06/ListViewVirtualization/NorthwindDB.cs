using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ListViewVirtualization
{
	public class NorthwindDB
	{
		private static string connectionString = Properties.Settings.Default.ConnectionString;

		public static int GetOrdersCount()
		{
			// Create the command and the connection.
			string sql = "SELECT COUNT(*) FROM Orders";
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand(sql, con);

			// Get the number of records.
			using (con)
			{
				con.Open();
				return (int)cmd.ExecuteScalar();
			}
		}

		public static DataTable GetOrders(int fromOrderID, int toOrderID)
		{
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand("GetOrdersByPage", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add(new SqlParameter("@FromID", SqlDbType.Int, 4));
			cmd.Parameters["@FromID"].Value = fromOrderID;
			cmd.Parameters.Add(new SqlParameter("@ToID", SqlDbType.Int, 4));
			cmd.Parameters["@ToID"].Value = toOrderID;

			// Prepare to fill a new DataSet.
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();

			// Get the appropriate "page" of order records.
			adapter.Fill(ds);
			ds.Tables[0].PrimaryKey = new DataColumn[] { ds.Tables[0].Columns["ID"] };
			return ds.Tables[0];
		}
	}
}