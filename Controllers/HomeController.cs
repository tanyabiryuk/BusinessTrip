﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BusinessTrip.Models;

namespace BusinessTrip.Controllers
{
    public class HomeController : Controller
    {
        BusinessTripContext db;
        public HomeController(BusinessTripContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Role.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
