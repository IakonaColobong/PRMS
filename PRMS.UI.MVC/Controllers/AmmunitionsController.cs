using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PRMS.DATA.EF;

namespace PRMS.UI.MVC.Controllers
{
    public class AmmunitionsController : Controller
    {
        private PoliceRMSEntities db = new PoliceRMSEntities();

        // GET: Ammunitions
        public ActionResult Index()
        {
            return View(db.Ammunitions.ToList());
        }

        // GET: Ammunitions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ammunition ammunition = db.Ammunitions.Find(id);
            if (ammunition == null)
            {
                return HttpNotFound();
            }
            return View(ammunition);
        }

        // GET: Ammunitions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ammunitions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Caliber,Supplier,Qty")] Ammunition ammunition)
        {
            if (ModelState.IsValid)
            {
                db.Ammunitions.Add(ammunition);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ammunition);
        }

        // GET: Ammunitions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ammunition ammunition = db.Ammunitions.Find(id);
            if (ammunition == null)
            {
                return HttpNotFound();
            }
            return View(ammunition);
        }

        // POST: Ammunitions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Caliber,Supplier,Qty")] Ammunition ammunition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ammunition).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ammunition);
        }

        // GET: Ammunitions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ammunition ammunition = db.Ammunitions.Find(id);
            if (ammunition == null)
            {
                return HttpNotFound();
            }
            return View(ammunition);
        }

        // POST: Ammunitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ammunition ammunition = db.Ammunitions.Find(id);
            db.Ammunitions.Remove(ammunition);
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
