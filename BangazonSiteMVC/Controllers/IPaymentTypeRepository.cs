using BangazonSiteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BangazonSiteMVC.Controllers
{
    interface IPaymentTypeRepository
    {
        void Save(PaymentType newCustomer);
        IEnumerable<PaymentType> GetAll();
    }
}