using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Hotel_API.Models;

namespace LKS_Hotel_API.Controllers
{
    public class LoginController : ApiController
    {
        hotel_lksEntities row = new hotel_lksEntities();

        [HttpPost]
        public IHttpActionResult post([FromBody] LoginModel model)
        {
            string pass = Encrypt.enc(model.password);

            string query = "select * from employee where username = '" + model.username + "' and password = '" + pass + "'";
            var user = row.Employees.SqlQuery(query).FirstOrDefault();
            if(user != null)
            {
                model.id = user.ID;
                model.name = user.Name;
                model.username = user.Username;

                return Ok(model);
            }

            return null;
        }
    }
}
