using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BangazonSiteMVC.Models
{
    public class PaymentType
    {
        [Key]
        public int PaymentTypeId { get; set; }

        public int CustomerId { get; set; }

        public string CardType { get; set; }

        public virtual Customer Customer { get; set; }
    }
}