using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace LKS_Hotel_API.Models
{
    public class Connection
    {
        public static string conn = @"Data Source=asmodeus;Initial Catalog=latian_hotel;Integrated Security=True";
    }
    public class Encrypt
    {
        public static string enc(string data)
        {
            using(SHA256Managed managed = new SHA256Managed())
            {
                return Convert.ToBase64String(managed.ComputeHash(Encoding.UTF8.GetBytes(data)));
            }

        }
    }
    public class Command
    {
        public static DataTable GetData(string com)
        {
            SqlConnection connection = new SqlConnection(Connection.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(com, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}