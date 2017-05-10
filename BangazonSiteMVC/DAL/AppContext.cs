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
        public AppContext() : base("BangazonMVC") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}