using BangazonSiteMVC.Controllers;
using BangazonSiteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BangazonSiteMVC.DAL
{
    public class OrderLineItemRepo : IOrderLineItemRepository
    {

        readonly AppContext _context;
        public OrderLineItemRepo(AppContext context)
        {
            _context = context;
        }
        public void AddOrderLineItem(OrderLineItem newOrderLIneItem)
        {
            throw new NotImplementedException();
        }

        public void GetOrderLineItem(int OrderLineItemID)
        {
            throw new NotImplementedException();
        }

        public void Save(OrderLineItem newOrderLineitem)
        {
            throw new NotImplementedException();
        }
    }
}