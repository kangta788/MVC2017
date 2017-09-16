using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialView.Models;// Here

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        // GET: Home/GetComments
        public ActionResult GetComments()
        {
            List<Comment> data = new List<Comment> {
                 new Comment{ID=100,Subject="A"},
                 new Comment{ID=200,Subject="B"},
                 new Comment{ID=300,Subject="C"}
               };
            return View(data);
        }

        public ActionResult GetComments2()
        {
            List<Comment> data = new List<Comment> {
                 new Comment{ID=400,Subject="D"},
                 new Comment{ID=500,Subject="E"},
                 new Comment{ID=600,Subject="F"}
               };
            return View(data);
        }


    }
}