using BangazonSiteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonSiteMVC.Controllers
{
    public interface IOrderRepository
    {
        void Save(Order newOrder);
    }
}
