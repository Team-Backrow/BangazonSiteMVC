using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BangazonSiteMVC.Models
{
    public class OrderLineItem
    {
        [Key]
        public int OrderLineItemId { get; set; }
        [Required]
        public int ProductId { get; set; }
    }
}