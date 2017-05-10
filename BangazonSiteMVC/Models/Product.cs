using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BangazonSiteMVC.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductType { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
    }
}