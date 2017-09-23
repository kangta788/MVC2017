using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public ActionResult Index()
        {
            ViewData["date1"] = DateTime.Now;
            ViewBag.date2 = DateTime.Now;
            TempData["date3"] = DateTime.Now;


            return View();
        }


        // GET: Home/TempDataDemo
        public ActionResult TempDataDemo()
        {
            ViewData["date1"] = DateTime.Now;
            ViewBag.date2 = DateTime.Now;
            TempData["date3"] = DateTime.Now;


            return RedirectToAction("TempDataDemo2");
            //會發現 ViewData跟 ViewBag過不去

        }
        // GET: Home/TempDataDemo2
        public ActionResult TempDataDemo2()
        {
            //View如下
           // < div >
           // < h1 > TempData Demo2 </ h1 >

           //    ViewData = @ViewData["date1"] < br /> 無法顯示
           //    ViewBag = @ViewBag.date2 < br />  無法顯示
           //    TempData = @TempData["date3"] < br /> 會顯示
   
           //</ div >

            return View();

        }

    }
}