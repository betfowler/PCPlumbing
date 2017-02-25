using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCPlumbing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Plumbing()
        {
            return View();
        }

        public ActionResult CentralHeating()
        {
            return View();
        }
        
        public ActionResult Boilers()
        {
            return View();
        }
        public ActionResult Bathrooms()
        {
            return View();
        }
        public ActionResult Renewable()
        {
            return View();
        }
        public ActionResult Advice()
        {
            return View();
        }
    }
}