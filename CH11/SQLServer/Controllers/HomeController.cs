using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod11_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["date1"] = DateTime.Now;
            ViewBag.date2 = DateTime.Now;

            TempData["date3"] = DateTime.Now;


            return RedirectToAction("TempDataDemo");

            //return View();
        }

        // GET: Home/TempDataDemo
        public ActionResult TempDataDemo()
        {
            TempData["date3"] = TempData["date3"] + DateTime.Now.ToString();

            return View();
        }

        // GET: Home/SessionDemo
        public ActionResult SessionDemo()
        {
            if (Session["count"] == null)
                Session["count"] = 0;
            else
                Session["count"] = (int)Session["count"] + 1;

            return View();
        }


    }
}