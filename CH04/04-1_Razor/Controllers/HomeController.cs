using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_1_Razor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //GET:Home/GetVideo
        public ActionResult GetVideo()
        {
             return File("~/Content/movie.mp4", "video/mp4");
        }
    }
}