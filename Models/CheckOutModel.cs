using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LKS_Hotel_API.Models
{
    public class CheckOutModel
    {
        public int reservationRoomId { set; get; }
        public int fdid { set; get; }
        public int qty { set; get; }
        public int totalPrice { set; get; }
        public int employeeId { set; get; }
    }
}