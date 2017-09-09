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

        // GET: Opera/Index?yy=1986    由網址帶參數進去
        public ActionResult Index(int? yy) 
        {
            Opera o = new Opera();
            o.OperaID = 2;
            o.Title = "歌劇魅影";
            //o.Year = 1986;
            o.Year = yy;
            o.Composer = "安德魯·洛伊·韋伯";

            return View(o);
        }





    }
}