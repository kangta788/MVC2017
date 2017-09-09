using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CH03_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public ActionResult Index()
        {
            return View();
        }


        // GET: Home/ReIndex
        public ActionResult ReIndex()
        {
            return RedirectToAction("Index","Home"); //開啟另一個Action
        }
    }
}