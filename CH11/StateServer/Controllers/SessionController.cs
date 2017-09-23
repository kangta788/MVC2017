using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Session/SessionDemo
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