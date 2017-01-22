using Hm1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hm1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product>list = new List<Product>()
            {
                new Product() {ProductId = 1, Name = "Banana", Description = "fruit", Price = 50 },
                new Product() {ProductId = 2, Name = "Cherry", Description = "fruit", Price = 150 },
                new Product() {ProductId = 3, Name = "Apple", Description = "fruit", Price = 250 }
            };
            return View(list);
        }
    }
}