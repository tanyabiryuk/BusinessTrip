using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessTrip.Models;

namespace BusinessTrip.Controllers
{
    public class applicationController : Controller
    {
        // GET: application
        public ActionResult Index()
        {
            return View();
        }

        // GET: application/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: application/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: application/Create
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

        // GET: application/Edit/5
        public ActionResult Edit(int id)
        {
            //Linq to SQL  class Instance created  
            businesstripEntities db = new businesstripEntities();

            //Fetching Skills Records in LIST Collection format.  
            var types = (from a in db.type orderby a.id select a).ToList();

            if (types.Count == 0)
            {
                types.AddRange(new List<type>
                {new type(1, "Відрядження по Україні"),
                new type(2, "Відрядження закордон")});
                foreach (type t in types) db.type.Add(t);
            }

            //Fetching specific Employee Record.  
            

            //Sending Employees list to View.  
            return View();
        }

        // POST: application/Edit/5
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

        // GET: application/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: application/Delete/5
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
