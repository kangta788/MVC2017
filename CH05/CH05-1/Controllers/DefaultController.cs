using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CH05_1.Controllers
{
   // [HandleError] //也可以放在每個ACctionResult上方
    public class DefaultController : Controller
    {
        // GET: Default
        [HandleError]
        public ActionResult Index()
        {
            int i = 0;
            int j = 10 / i;
            return View();
        }

        [HandleError(View = "Error2")]
        public ActionResult ExceptionDemo()
        {

            int i = 0;
            int j = 10 / i;
            return View();
        }
    }
}