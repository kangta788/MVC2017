using MVC_Empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Empty.Controllers
{
    public class OperaController : Controller
    {
        // GET: Opera  如果沒有寫 就是預設抓Index
        // GET: Opera/Index
        public ActionResult Index()
        {
            Opera o = new Opera();
            o.OperaID = 1;
            o.Title = "尤利迪西";
            o.Year = 1600;
            o.Composer = "佩里";

            return View(o);
        }
    }
}