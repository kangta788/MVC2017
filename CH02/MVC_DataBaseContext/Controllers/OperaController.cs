using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataBaseContext.DAL;

namespace MVC_DataBaseContext.Controllers
{
    public class OperaController : Controller
    {
        //自動建立資料表
        private OperaContext contex = new OperaContext();


        // GET: Opera
        public ActionResult Index()
        {
            return View(contex.Operas.ToList()); //等同於select
        }
    }
}