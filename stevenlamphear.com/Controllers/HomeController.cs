using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stevenlamphear.com.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public ActionResult Developer()
        {
            ViewBag.Title = "Developer";
            return View();
        }

        public ActionResult Composer()
        {
            ViewBag.Title = "Composer";
            return View();
        }

        public ActionResult Performer()
        {
            ViewBag.Title = "Performer";
            return View();
        }

        public ActionResult Links()
        {
            ViewBag.Title = "Links";
            return View();
        }
    }
}