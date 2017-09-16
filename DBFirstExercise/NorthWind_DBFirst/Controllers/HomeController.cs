using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthWind_DBFirst.Models.DAL;

namespace NorthWind_DBFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public ActionResult Index()
        {
            return View();
        }
        // GET: Home/ProductByID/1
        public ActionResult ProductByID(int Id)
        {
            NorthwindEntities db = new NorthwindEntities();//注意這邊 名稱很重要
            var result = db.Products.Find(Id);

            return View(result);
        }

        // GET: Home/ProductsByCategory/1
        public ActionResult ProductsByCategory(int Id)
        {
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.CategoryID == Id
                        select p;

            var result = query.ToList();

            return View(result);
        }

    }
}