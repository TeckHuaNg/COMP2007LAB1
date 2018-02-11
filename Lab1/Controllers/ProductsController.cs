using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var products = new List<Product>();
            products.Add(new Product { Name = "Laptop" });
            products.Add(new Product { Name = "Tablet" });
            products.Add(new Product { Name = "Desktop" });

            return View(products);
        }

        public ActionResult Details(string name)
        {
            ViewBag.Detail = "You selected product: " + name;

            return View();
        }


    }
}