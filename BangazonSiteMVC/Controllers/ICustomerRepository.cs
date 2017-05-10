using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BangazonSiteMVC.Models;

namespace BangazonSiteMVC.Controllers
{
    interface ICustomerRepository
    {
        void Save(Customer newCustomer);
        IEnumerable<Customer> GetAll();
    }
}
