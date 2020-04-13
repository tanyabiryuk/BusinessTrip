using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessTrip.Models;

namespace BusinessTrip.Controllers
{
    public class applicationsController : Controller
    {
        private businesstripContext db = new businesstripContext();

        // GET: applications
        public ActionResult Index()
        {
            var application = db.application.Include(a => a.app_fundation).Include(a => a.app_transport).Include(a => a.user);
            return View(application.ToList());
        }

        // GET: applications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            application application = db.application.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // GET: applications/Create
        public ActionResult Create()
        {
            ViewBag.app_fundation_Id = new SelectList(db.app_fundation, "id", "id");
            ViewBag.app_transport_Id = new SelectList(db.app_transport, "id", "id");
            ViewBag.user_Id = new SelectList(db.user, "id", "last_name");
            return View();
        }

        // POST: applications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,user_Id,email,fullname,main_place_of_work,position_in_combination,type,purpose,saving_salary,trip_city,trip_country,institution,start_date,end_date,itinerary,app_transport_Id,payment,app_fundation_Id,institutionLocation")] application application)
        {
            if (ModelState.IsValid)
            {
                db.application.Add(application);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.app_fundation_Id = new SelectList(db.app_fundation, "id", "id", application.app_fundation_Id);
            ViewBag.app_transport_Id = new SelectList(db.app_transport, "id", "id", application.app_transport_Id);
            ViewBag.user_Id = new SelectList(db.user, "id", "last_name", application.user_Id);
            return View(application);
        }

        // GET: applications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            application application = db.application.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            ViewBag.app_fundation_Id = new SelectList(db.app_fundation, "id", "id", application.app_fundation_Id);
            ViewBag.app_transport_Id = new SelectList(db.app_transport, "id", "id", application.app_transport_Id);
            ViewBag.user_Id = new SelectList(db.user, "id", "last_name", application.user_Id);
            return View(application);
        }

        // POST: applications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,user_Id,email,fullname,main_place_of_work,position_in_combination,type,purpose,saving_salary,trip_city,trip_country,institution,start_date,end_date,itinerary,app_transport_Id,payment,app_fundation_Id,institutionLocation")] application application)
        {
            if (ModelState.IsValid)
            {
                db.Entry(application).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.app_fundation_Id = new SelectList(db.app_fundation, "id", "id", application.app_fundation_Id);
            ViewBag.app_transport_Id = new SelectList(db.app_transport, "id", "id", application.app_transport_Id);
            ViewBag.user_Id = new SelectList(db.user, "id", "last_name", application.user_Id);
            return View(application);
        }

        // GET: applications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            application application = db.application.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // POST: applications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            application application = db.application.Find(id);
            db.application.Remove(application);
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
