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
    public class ProjetosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Projetos
        public ActionResult Index()
        {
            return View(db.Projetos.ToList());
        }

        // GET: Projetos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projetos projetos = db.Projetos.Find(id);
            if (projetos == null)
            {
                return HttpNotFound();
            }
            return View(projetos);
        }

        // GET: Projetos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projetos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjetosCod,ProjetosVersao,ProjetoDescricao,ProjetoObs,Cliente")] Projetos projetos)
        {
            if (ModelState.IsValid)
            {
                db.Projetos.Add(projetos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projetos);
        }

        // GET: Projetos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projetos projetos = db.Projetos.Find(id);
            if (projetos == null)
            {
                return HttpNotFound();
            }
            return View(projetos);
        }

        // POST: Projetos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjetosCod,ProjetosVersao,ProjetoDescricao,ProjetoObs,Cliente")] Projetos projetos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projetos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projetos);
        }

        // GET: Projetos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projetos projetos = db.Projetos.Find(id);
            if (projetos == null)
            {
                return HttpNotFound();
            }
            return View(projetos);
        }

        // POST: Projetos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Projetos projetos = db.Projetos.Find(id);
            db.Projetos.Remove(projetos);
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
