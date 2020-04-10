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
    public class NamsController : Controller
    {
        private Sem3FinalProjectTestContext db = new Sem3FinalProjectTestContext();

        // GET: Nams
        public ActionResult Index()
        {
            return View(db.Nams.ToList());
        }

        // GET: Nams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nam nam = db.Nams.Find(id);
            if (nam == null)
            {
                return HttpNotFound();
            }
            return View(nam);
        }

        // GET: Nams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Nam nam)
        {
            if (ModelState.IsValid)
            {
                db.Nams.Add(nam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nam);
        }

        // GET: Nams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nam nam = db.Nams.Find(id);
            if (nam == null)
            {
                return HttpNotFound();
            }
            return View(nam);
        }

        // POST: Nams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Nam nam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nam);
        }

        // GET: Nams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nam nam = db.Nams.Find(id);
            if (nam == null)
            {
                return HttpNotFound();
            }
            return View(nam);
        }

        // POST: Nams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nam nam = db.Nams.Find(id);
            db.Nams.Remove(nam);
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
