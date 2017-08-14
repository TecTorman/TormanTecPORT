using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TormanDomain;
using TormanTec.Models;

namespace TormanTec.Controllers
{
    public class SobresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Sobres
        public ActionResult Index()
        {
            return View(db.Sobres.ToList());
        }

        // GET: Sobres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sobre sobre = db.Sobres.Find(id);
            if (sobre == null)
            {
                return HttpNotFound();
            }
            return View(sobre);
        }

        // GET: Sobres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sobres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodSobre,Titulo,Descricao,Body,Type")] Sobre sobre)
        {
            if (ModelState.IsValid)
            {
                db.Sobres.Add(sobre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sobre);
        }

        // GET: Sobres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sobre sobre = db.Sobres.Find(id);
            if (sobre == null)
            {
                return HttpNotFound();
            }
            return View(sobre);
        }

        // POST: Sobres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodSobre,Titulo,Descricao,Body,Type")] Sobre sobre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sobre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sobre);
        }

        // GET: Sobres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sobre sobre = db.Sobres.Find(id);
            if (sobre == null)
            {
                return HttpNotFound();
            }
            return View(sobre);
        }

        // POST: Sobres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sobre sobre = db.Sobres.Find(id);
            db.Sobres.Remove(sobre);
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
