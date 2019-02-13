using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SporWebMvc.Models;

namespace SporWebMvc.Controllers
{
    public class EtkinliklersController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Etkinliklers
        public ActionResult Index()
        {
            var etkinlik = db.Etkinlik.Include(e => e.EtkinlikTip);
            return View(etkinlik.ToList());
        }

        // GET: Etkinliklers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Etkinlikler etkinlikler = db.Etkinlik.Find(id);
            if (etkinlikler == null)
            {
                return HttpNotFound();
            }
            return View(etkinlikler);
        }

        // GET: Etkinliklers/Create
        public ActionResult Create()
        {
            ViewBag.TipId = new SelectList(db.EtkinlikTip, "Id", "Tip");
            return View();
        }

        // POST: Etkinliklers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EtkinlikAdi,TipId,MekanId,EtkinlikTarihi,Kontenjan,isActive,Sid,CreateDate,UpdateDate")] Etkinlikler etkinlikler)
        {
            if (ModelState.IsValid)
            {
                db.Etkinlik.Add(etkinlikler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TipId = new SelectList(db.EtkinlikTip, "Id", "Tip", etkinlikler.TipId);
            return View(etkinlikler);
        }

        // GET: Etkinliklers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Etkinlikler etkinlikler = db.Etkinlik.Find(id);
            if (etkinlikler == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipId = new SelectList(db.EtkinlikTip, "Id", "Tip", etkinlikler.TipId);
            return View(etkinlikler);
        }

        // POST: Etkinliklers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EtkinlikAdi,TipId,MekanId,EtkinlikTarihi,Kontenjan,isActive,Sid,CreateDate,UpdateDate")] Etkinlikler etkinlikler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(etkinlikler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipId = new SelectList(db.EtkinlikTip, "Id", "Tip", etkinlikler.TipId);
            return View(etkinlikler);
        }

        // GET: Etkinliklers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Etkinlikler etkinlikler = db.Etkinlik.Find(id);
            if (etkinlikler == null)
            {
                return HttpNotFound();
            }
            return View(etkinlikler);
        }

        // POST: Etkinliklers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Etkinlikler etkinlikler = db.Etkinlik.Find(id);
            db.Etkinlik.Remove(etkinlikler);
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
