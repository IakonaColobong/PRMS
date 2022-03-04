using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PRMS.DATA.EF;
using PagedList;
using PagedList.Mvc;

namespace PRMS.UI.MVC.Controllers
{
    [Authorize]
    public class FirearmsController : Controller
    {
        private PoliceRMSEntities db = new PoliceRMSEntities();

        // GET: Firearms
        public ActionResult Index()
        {
            var firearms = db.Firearms.Include(f => f.Employee);
            return View(firearms.ToList());
        }

        // GET: Firearms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Firearm firearm = db.Firearms.Find(id);
            if (firearm == null)
            {
                return HttpNotFound();
            }
            return View(firearm);
        }

        // GET: Firearms/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeId", "First_Name");
            return View();
        }

        // POST: Firearms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SerialNumber,Make,Model,Location,EmployeeID,VehicleNumber,PurchasePrice")] Firearm firearm)
        {
            if (ModelState.IsValid)
            {
                db.Firearms.Add(firearm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeId", "First_Name", firearm.EmployeeID);
            return View(firearm);
        }

        // GET: Firearms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Firearm firearm = db.Firearms.Find(id);
            if (firearm == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeId", "First_Name", firearm.EmployeeID);
            return View(firearm);
        }

        // POST: Firearms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SerialNumber,Make,Model,Location,EmployeeID,VehicleNumber,PurchasePrice")] Firearm firearm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(firearm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "EmployeeId", "First_Name", firearm.EmployeeID);
            return View(firearm);
        }

        // GET: Firearms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Firearm firearm = db.Firearms.Find(id);
            if (firearm == null)
            {
                return HttpNotFound();
            }
            return View(firearm);
        }

        // POST: Firearms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Firearm firearm = db.Firearms.Find(id);
            db.Firearms.Remove(firearm);
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
