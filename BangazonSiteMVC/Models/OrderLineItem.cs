using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BangazonSiteMVC.Models
{
    public class OrderLineItem
    {
        public int OrderLineItemId { get; set; }

        public int ProductId { get; set; }
    }
}