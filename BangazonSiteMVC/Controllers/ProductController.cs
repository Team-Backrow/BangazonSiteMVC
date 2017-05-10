using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BangazonSiteMVC.Models;
using BangazonSiteMVC.Controllers;

namespace BangazonSiteMVC.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddAProduct(Product newProduct)
        {
            _productRepository.Save(newProduct);

            return View();
        }
    }
}