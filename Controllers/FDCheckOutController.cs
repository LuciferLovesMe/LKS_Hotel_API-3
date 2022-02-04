using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Hotel_API.Models;

namespace LKS_Hotel_API.Controllers
{
    public class FDCheckOutController : ApiController
    {
        SqlConnection connection = new SqlConnection(Connection.conn);
        SqlCommand command;

        public string[] post ([FromBody] CheckOutModel model)
        {
            command = new SqlCommand("insert into fdcheckout values(" + model.reservationRoomId + ", " + model.fdid + ", " + model.qty + ", " + model.totalPrice + ", " + model.totalPrice + ")", connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return new string[] { "Successfully Inserted" };
            }
            catch (Exception ex)
            {
                return new string[] { "" + ex };
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
