using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Login_hash
{
    public static class DatabaseHelper
    {
        private static string connectionString = @"Server=SQLEXPRESS;Database=hashcj3022501;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
