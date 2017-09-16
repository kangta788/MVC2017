using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mod02_01.Models;
using Mod02_01.DAL;
using System.Net;
using System.Data.Entity;

namespace Mod02_01.Controllers
{
    public class OperaController : Controller
    {
        private OperaContext context = new OperaContext();

        // GET: Opera
        // GET: Opera/Index
        public ActionResult Index()
        {
            return View(context.Operas.ToList());
        }

        // GET: Opera/Details/1
        // GET: Opera/Details?id=1
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Opera o = context.Operas.Find(id);
            if (o == null)
                return HttpNotFound();
            return View(o);
        }

        // 新增歌劇
        // GET: Opera/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Opera/Create
        [HttpPost]
        public ActionResult Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Operas.Add(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(opera);
        }

        // 修改歌劇
        // GET: Opera/Edit/1
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Opera o = context.Operas.Find(id);
            if (o == null)
            {
                return HttpNotFound();
            }
            return View(o);
        }

        // POST: Opera/Edit
        [HttpPost]
        public ActionResult Edit(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Entry(opera).State = EntityState.Modified;

                //Opera o = context.Operas.Find(opera.OperaID);
                //o.Title = opera.Title;
                //o.Year = opera.Year;
                //o.Composer = opera.Composer;

                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(opera);
        }

        // 刪除歌劇
        // GET: Opera/Delete/1
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

        //    Opera o = context.Operas.Find(id);
        //    if (o == null)
        //        return HttpNotFound();

        //    return View(o);
        //}
        // POST: Opera/Delete/1
        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int? id)
        //{

        //    Opera o = context.Operas.Find(id);
        //    context.Operas.Remove(o);
        //    context.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        // GET: Opera/Delete/1
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Opera o = context.Operas.Find(id);
            if (o == null)
                return HttpNotFound();
            context.Operas.Remove(o);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // 查詢近代歌劇
        // GET: Opera/FilterData?number=2
        public ActionResult FilterData(int number)
        {
            //LINQ
            var query = from o in context.Operas
                        orderby o.Year descending
                        select o;

            var result = query.Take(number).ToList();

            return View("Index", result);
        }


        //自訂繞送
        // GET: Opera/DetailsByTitle?title=Wozzeck
        // GET: Opera/Title/Wozzeck
        [Route("Opera/Title/{title}")]
        public ActionResult DetailsByTitle(string title)
        {
            Opera opera = context.Operas.FirstOrDefault<Opera>(o => o.Title == title);
            if (opera == null)
            {
                return HttpNotFound();
            }

            return View("Details", opera);
        }


    }
}