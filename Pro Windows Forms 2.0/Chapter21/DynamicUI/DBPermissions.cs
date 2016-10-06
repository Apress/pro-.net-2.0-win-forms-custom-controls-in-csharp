using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DynamicUI
{
    public class DBPermissions
    {
        public enum State
        {
            Normal = 0,
            Disabled = 1,
            Hidden = 2
        }

        public enum Level
        {
            Admin,
            User
        }

        private SqlConnection con= new SqlConnection(
            Properties.Settings.Default.DBConnectionString);
            
        
        public DataTable GetPermissions(Level userLevel)
        {
            // Permissions isn't actually actually a table in our data source.
            // Instead, it's a view that combines the important information
            // from all three tables using a Join query.
            string selectPermissions = "SELECT * FROM Permissions WHERE LevelName=@LevelName";
            SqlCommand cmd = new SqlCommand(selectPermissions, con);

            SqlParameter param = new SqlParameter("@LevelName",
              Enum.GetName(typeof(Level), userLevel));
            cmd.Parameters.Add(param);
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Permissions");

            return ds.Tables["Permissions"];
        }
    }

}
