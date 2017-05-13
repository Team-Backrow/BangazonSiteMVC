using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BangazonSiteMVC.Controllers;
using BangazonSiteMVC.Models;

namespace BangazonSiteMVC.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        readonly AppContext _context;
        public CustomerRepository(AppContext context)
        {
            _context = context;
        }

        public Customer GetCustomers(int id)
        {
            var newCustomer = new Customer
            {
                Id = 1,
                FullName = "Josh Kilgore"
            };
            return newCustomer;
        }

        public void Save(Models.Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
        }
    }
}