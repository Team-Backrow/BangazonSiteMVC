using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BangazonSiteMVC.Api.Controllers
{
    [RoutePrefix("api/PaymentType")]
    public class PaymentTypeController : Controller
    { 
        // GET: PaymentType
        public ActionResult Index()
        {
            return View();
        }
    }
}