using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Hotel_API.Models;

namespace LKS_Hotel_API.Controllers
{
    public class FDController : ApiController
    {
        SqlConnection connection = new SqlConnection(Connection.conn);
        
        [HttpGet]
        public DataTable data()
        {
            string com = "select * from foodsAndDrinks";
            return Command.GetData(com);
        }
    }
}
