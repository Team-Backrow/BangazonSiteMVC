using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BangazonSiteMVC.Models;

namespace BangazonSiteMVC.Controllers
{
    public interface ICustomerRepository
    {
        void Save(Customer newCustomer);
        Customer GetCustomers(int id);
    }
}
