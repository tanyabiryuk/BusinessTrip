using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessTrip.Models;

namespace BusinessTrip.Controllers
{
    public class appController : Controller
    {
        private BusinessTrip.Models.businesstripEntities db = new Models.businesstripEntities();
        // GET: app
        public ActionResult Index()
        {
            ViewBag.roles = db.role.ToList();
            ViewBag.types = db.type.ToList();
            ViewBag.purposes = db.purpose.ToList();
            ViewBag.saving_salary = db.saving_salary.ToList();
            ViewBag.saving_salary = db.saving_salary.ToList();
            ViewBag.institution = db.institution.ToList();
            ViewBag.transport = db.transport.ToList();
            ViewBag.payment = db.payment.ToList();
            ViewBag.foundation = db.foundation.ToList();
            return View();
        }

        // GET: app/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: app/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: app/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: app/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: app/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: app/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: app/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
