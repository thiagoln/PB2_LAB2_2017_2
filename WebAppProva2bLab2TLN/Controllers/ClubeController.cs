using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppProva2bLab2TLN.Models;

namespace WebAppProva2bLab2TLN.Controllers
{
    public class ClubeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Clube
        public ActionResult Index()
        {
            return View(db.Clubes.ToList());
        }

        // GET: Clube/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clube clube = db.Clubes.Find(id);
            if (clube == null)
            {
                return HttpNotFound();
            }
            return View(clube);
        }

        // GET: Clube/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clube/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClubeId,RazaoSocial,CNPJ,Descricao")] Clube clube)
        {
            if (ModelState.IsValid)
            {
                db.Clubes.Add(clube);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clube);
        }

        // GET: Clube/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clube clube = db.Clubes.Find(id);
            if (clube == null)
            {
                return HttpNotFound();
            }
            return View(clube);
        }

        // POST: Clube/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClubeId,RazaoSocial,CNPJ,Descricao")] Clube clube)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clube).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clube);
        }

        // GET: Clube/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clube clube = db.Clubes.Find(id);
            if (clube == null)
            {
                return HttpNotFound();
            }
            return View(clube);
        }

        // POST: Clube/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Clube clube = db.Clubes.Find(id);
            db.Clubes.Remove(clube);
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
