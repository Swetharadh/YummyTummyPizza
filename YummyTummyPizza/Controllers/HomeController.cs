using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YummyTummyPizza.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View();
        }
        public ActionResult VegPizza()
        {
            return View();
        }
        public ActionResult NonVegPizza()
        {
            return View();
        }
        public ActionResult Sides()
        {
            return View();
        }
        public ActionResult MyOrder()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

    }
}