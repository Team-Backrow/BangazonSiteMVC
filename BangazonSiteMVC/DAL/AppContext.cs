using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BangazonSiteMVC.Models;

namespace BangazonSiteMVC.DAL
{
    public class AppContext
    {
        public DbSet<Product> Products { get; set; }
    }
}