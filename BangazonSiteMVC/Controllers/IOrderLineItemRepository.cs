﻿using BangazonSiteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangazonSiteMVC.Controllers
{
    public interface IOrderLineItemRepository
    {
        void AddOrderLineItem(OrderLineItem newOrderLineItem);
        void GetOrderLineItem(int OrderLineItem);
        void Save(OrderLineItem newOrderLineitem);
    }
}
