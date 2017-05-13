using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BangazonSiteMVC.Models;

namespace BangazonSiteMVC.DAL
{
    public class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<OrderLineItem> OrderLineItems { get; set; }

    }
}