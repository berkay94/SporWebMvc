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
    public class MekansController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Mekans
        public ActionResult Index()
        {
            var mekanlar = db.Mekanlar.Include(m => m.Ilceler);
            return View(mekanlar.ToList());
        }

        // GET: Mekans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mekan mekan = db.Mekanlar.Find(id);
            if (mekan == null)
            {
                return HttpNotFound();
            }
            return View(mekan);
        }

        // GET: Mekans/Create
        public ActionResult Create()
        {
            ViewBag.IlceId = new SelectList(db.Ilceler, "Id", "Ad");
            return View();
        }

        // POST: Mekans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MekanAdi,IlceId,CreateDate,UpdateDate")] Mekan mekan)
        {
            if (ModelState.IsValid)
            {
                db.Mekanlar.Add(mekan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IlceId = new SelectList(db.Ilceler, "Id", "Ad", mekan.IlceId);
            return View(mekan);
        }

        // GET: Mekans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mekan mekan = db.Mekanlar.Find(id);
            if (mekan == null)
            {
                return HttpNotFound();
            }
            ViewBag.IlceId = new SelectList(db.Ilceler, "Id", "Ad", mekan.IlceId);
            return View(mekan);
        }

        // POST: Mekans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MekanAdi,IlceId,CreateDate,UpdateDate")] Mekan mekan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mekan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IlceId = new SelectList(db.Ilceler, "Id", "Ad", mekan.IlceId);
            return View(mekan);
        }

        // GET: Mekans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mekan mekan = db.Mekanlar.Find(id);
            if (mekan == null)
            {
                return HttpNotFound();
            }
            return View(mekan);
        }

        // POST: Mekans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mekan mekan = db.Mekanlar.Find(id);
            db.Mekanlar.Remove(mekan);
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
