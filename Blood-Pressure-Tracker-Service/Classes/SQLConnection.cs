using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace Blood_Pressure_Tracker_Service.Classes
{
    public class SQLConnection
    {
        public static SqlConnection createConnection()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Blood_Pressure_DB;Integrated Security=True";
            SqlConnection connction = new SqlConnection(connectionString);
            return connction;
        }
    }
}