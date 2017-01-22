using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducing.Controllers
{
    public class HomeTestController : Controller
    {
        // GET: HomeTest
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
    }
}