using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BangazonSiteMVC.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderLineItemId { get; set; }
        public int PaymentTypeId { get; set; }
    }
}