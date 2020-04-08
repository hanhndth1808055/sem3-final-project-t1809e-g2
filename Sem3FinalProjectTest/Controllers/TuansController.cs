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
    public class TuansController : Controller
    {
        private Sem3FinalProjectTestContext db = new Sem3FinalProjectTestContext();

        // GET: Tuans
        public ActionResult Index()
        {
            return View(db.Tuans.ToList());
        }

        // GET: Tuans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuan tuan = db.Tuans.Find(id);
            if (tuan == null)
            {
                return HttpNotFound();
            }
            return View(tuan);
        }

        // GET: Tuans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tuans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Tuan tuan)
        {
            if (ModelState.IsValid)
            {
                db.Tuans.Add(tuan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tuan);
        }

        // GET: Tuans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuan tuan = db.Tuans.Find(id);
            if (tuan == null)
            {
                return HttpNotFound();
            }
            return View(tuan);
        }

        // POST: Tuans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Tuan tuan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tuan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tuan);
        }

        // GET: Tuans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tuan tuan = db.Tuans.Find(id);
            if (tuan == null)
            {
                return HttpNotFound();
            }
            return View(tuan);
        }

        // POST: Tuans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tuan tuan = db.Tuans.Find(id);
            db.Tuans.Remove(tuan);
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
