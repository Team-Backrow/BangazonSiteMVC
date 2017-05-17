using BangazonSiteMVC.Controllers;
using BangazonSiteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BangazonSiteMVC.DAL
{
    public class OrderRepository : IOrderRepository
    {
        readonly AppContext _context;

        public OrderRepository(AppContext context)
        {
            _context = context;
        }

        public Order GetOrder(int id)
        {
            return _context.Orders.Find(id);
        }

        public void Save(Order newOrder)
        {
            _context.Orders.Add(newOrder);
            _context.SaveChanges();
        }
    }
}