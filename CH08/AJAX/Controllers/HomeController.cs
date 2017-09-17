using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJAX.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/HelloWorld  (for partial view)
        public ActionResult HelloWorld()
        {
            ViewBag.message = "HelloWorld:" + DateTime.Now.ToString();
            return PartialView();//*
        }

        // GET: Home/HelloWorld2  (for partial view)
        public ActionResult HelloWorld2(string username)
        {
            ViewBag.message = "HelloWorld:" +username+ DateTime.Now.ToString();
            return PartialView("HelloWorld");//*
        }

    }
}