using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCrudTest2.Controllers
{
    public class ContactController : Controller
    {
        private CalMaster db = new CalMaster();

        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View(db.CALPlant1.ToList());
        }

        //
        // GET: /Contact/Details/5

        public ActionResult Details(int id = 0)
        {
            CALPlant1 calplant1 = db.CALPlant1.Find(id);
            if (calplant1 == null)
            {
                return HttpNotFound();
            }
            return View(calplant1);
        }

        //
        // GET: /Contact/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Contact/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CALPlant1 calplant1)
        {
            if (ModelState.IsValid)
            {
                db.CALPlant1.Add(calplant1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(calplant1);
        }

        //
        // GET: /Contact/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CALPlant1 calplant1 = db.CALPlant1.Find(id);
            if (calplant1 == null)
            {
                return HttpNotFound();
            }
            return View(calplant1);
        }

        //
        // POST: /Contact/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CALPlant1 calplant1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calplant1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calplant1);
        }

        //
        // GET: /Contact/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CALPlant1 calplant1 = db.CALPlant1.Find(id);
            if (calplant1 == null)
            {
                return HttpNotFound();
            }
            return View(calplant1);
        }

        //
        // POST: /Contact/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CALPlant1 calplant1 = db.CALPlant1.Find(id);
            db.CALPlant1.Remove(calplant1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}