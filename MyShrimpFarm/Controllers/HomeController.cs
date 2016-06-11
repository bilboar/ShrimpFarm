using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShrimpFarm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The <strong>All-Spark</strong> of shrimping applications.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "How to reach us.";

            return View();
        }
    }
}