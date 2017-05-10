using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BangazonSiteMVC.Controllers;

namespace BangazonSiteMVC.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        readonly AppContext _context;
        public CustomerRepository(AppContext context)
        {
            _context = context;
        }

        public void Save(Models.Customer newCustomer)
        {
            _context.Ducks.Add(newCustomer);
            _context.SaveChanges();
        }
    }
}