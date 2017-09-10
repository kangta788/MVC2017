using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataBaseContext.DAL;
using System.Net;
using MVC_DataBaseContext.Models;
using System.Data.Entity;

namespace MVC_DataBaseContext.Controllers
{
    public class OperaController : Controller
    {
        //自動建立資料表 ?
        private OperasDB db = new OperasDB();

        //(1)首頁
        // GET: Opera/Index
        public ActionResult Index()
        {
            return View(db.Operas.ToList()); //等同於select
        }


        //(2)詳細頁面
        // GET: Opera/Details/1
        // GET: Opera/Details?id=1

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                //如果沒有傳id的話 如Opera/Details
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            Opera o = db.Operas.Find(id);
            if (o == null) { return HttpNotFound(); }
            else
            {
                return View(o);
            }
        }

        // insert
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
                db.Operas.Add(opera);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(opera);
        }

        // GET: Opera/Edit/1
        public ActionResult Edit(int? id)
        {
            //以防萬一
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //開始處理
            Opera o = db.Operas.Find(id);//找出那個ROW
            if (o == null)
            {
                return HttpNotFound();//找不到

            }
            return View(o);//找到後傳到View


        }

        // POST: Opera/Edit
        [HttpPost]
        public ActionResult Edit(Opera opera)
        {
            if (ModelState.IsValid)
            {
                db.Entry(opera).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(opera);
        }



        //刪除
        //GET
        public ActionResult Delete(int? id)
        {
            //以防萬一
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //開始處理
            Opera o = db.Operas.Find(id);//找出那個ROW
            if (o == null)
            {
                return HttpNotFound();//找不到

            }
            return View(o);//找到後傳到View
        }

        //POST
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Opera o = db.Operas.Find(id);
            db.Operas.Remove(o);
            db.SaveChanges();
            return RedirectToAction("Index","Opera");

        }



        //直接刪除
        // GET: Opera/Delete2/1
        public ActionResult Delete2(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Opera o = db.Operas.Find(id);
            if (o == null)
                return HttpNotFound();
            db.Operas.Remove(o);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}