using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Hotel_API.Models;

namespace LKS_Hotel_API.Controllers
{
    public class RoomController : ApiController
    {
        [HttpGet]
        public DataTable data()
        {
            string com = "select * room_view";
            return Command.GetData(com);
        }
    }
}
