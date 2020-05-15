using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessTrip.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusinessTrip.Controllers
{
    public class MenuController : Controller
    {
        private BusinessTripContext db;
        public MenuController(BusinessTripContext _db)
        {
            db = _db;
        }

        public IActionResult MenuLayout()
        {
            var list = db.User.FirstOrDefault(u => u.Email == User.Identity.Name);
            return View(list);
        }
    }
}