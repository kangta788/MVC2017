using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mod04_09.DAL;
using Mod04_09.Models;

namespace Mod04_09.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/ProductByID/1
        public ActionResult ProductByID(int Id)
        {
            ProductSystem ps = new ProductSystem();
            var result = ps.GetProductByID(Id);

            return View(result);
        }


        // GET: Home/ProductsByCategory/1
        public ActionResult ProductsByCategory(int Id)
        {
            ProductSystem ps = new ProductSystem();
            var result = ps.GetProductsByCategoryID(Id);

            return View(result);
        }

    }
}