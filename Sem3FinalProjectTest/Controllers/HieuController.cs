using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sem3FinalProjectTest.Data;
using Sem3FinalProjectTest.Models;

namespace Sem3FinalProjectTest.Controllers
{
    public class HieuController : Controller
    {
        private Sem3FinalProjectTestContext db = new Sem3FinalProjectTestContext();

        // GET: Hieu
        public ActionResult Index()
        {
            return View(db.Hieux.ToList());
        }

        // GET: Hieu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hieu hieu = db.Hieux.Find(id);
            if (hieu == null)
            {
                return HttpNotFound();
            }
            return View(hieu);
        }

        // GET: Hieu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hieu/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age")] Hieu hieu)
        {
            if (ModelState.IsValid)
            {
                db.Hieux.Add(hieu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hieu);
        }

        // GET: Hieu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hieu hieu = db.Hieux.Find(id);
            if (hieu == null)
            {
                return HttpNotFound();
            }
            return View(hieu);
        }

        // POST: Hieu/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age")] Hieu hieu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hieu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hieu);
        }

        // GET: Hieu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hieu hieu = db.Hieux.Find(id);
            if (hieu == null)
            {
                return HttpNotFound();
            }
            return View(hieu);
        }

        // POST: Hieu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hieu hieu = db.Hieux.Find(id);
            db.Hieux.Remove(hieu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
