using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09_03_JQery_AJAX.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/AjaxDemo
        public ActionResult AjaxDemo()
        {
            return View();
        }

        // GET: Home/HelloWorld?username=John
        public ActionResult HelloWorld(string username)
        {
            ViewBag.message = username + " -- " + DateTime.Now;
            return PartialView();
        }

        // GET: Home/JsonData?id=2&name=John
        // GET: Home/JsonData/2?name=John
        public ActionResult JsonData(string id, string name)
        {
            var data = new { empId = id, EmpName = name, Age = DateTime.Now.Millisecond };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}