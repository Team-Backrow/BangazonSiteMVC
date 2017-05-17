using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BangazonSiteMVC.Models
{
    public class Order
    {
        public Order()
        {
            LineItems = new List<OrderLineItem>();
        }
        public int OrderId { get; set; }
        public virtual List<OrderLineItem> LineItems { get; set; }
        public virtual PaymentType PaymentType { get; set; }

    }
}