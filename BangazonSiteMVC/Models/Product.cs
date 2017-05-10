using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BangazonSiteMVC.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public string Description { get; set; }

        public int CustomerId { get; set; }

        public int ProductTypeId { get; set; }
        //[ForeignKey("ProductTypeId")]
        //public ProductType ProductType { get; set; }
    }
}