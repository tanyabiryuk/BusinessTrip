using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessTrip.Models;
using Microsoft.AspNetCore.Authorization;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using static BusinessTrip.Models.Application;

namespace BusinessTrip.Controllers
{
    public class ApplicationsController : Controller
    {
        private readonly BusinessTripContext _context;

        public ApplicationsController(BusinessTripContext context)
        {
            _context = context;
        }


      
        //public ActionResult GenerateApp(int id)
        //{
        //    Application request = _context.Application.Find(id);

        //    if (request != null)
        //    {
        //        //Initialize HTML to PDF converter 
        //        HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);
        //        WebKitConverterSettings settings = new WebKitConverterSettings();
        //        //Set WebKit path
        //        settings.WebKitPath = Server.MapPath("~/QtBinaries");
        //        //Assign WebKit settings to HTML converter
        //        htmlConverter.ConverterSettings = settings;
        //        //Get the current URL
        //        string url = HttpContext.Current.Request.Url.AbsoluteUri;
        //        //Convert URL to PDF
        //        PdfDocument document = htmlConverter.Convert(url);
        //        //Save the document
        //        document.Save("Output.pdf", HttpContext.Current.Response, HttpReadType.Save);


        //        return PartialView("GenerateApp", request);
        //    }
        //    return View("RequestList");
        //}
        //заявки користувача
        [Authorize(Roles = "user")]
       
        public IActionResult Index()
        {
            // получаем текущего пользователя
            User user = _context.User.Where(m => m.Email == HttpContext.User.Identity.Name).FirstOrDefault();

            var requests = _context.Application.Where(r => r.UserId == user.Id) //получаем заявки для текущего пользователя
                                     
                                    .Include(r => r.Lifecycle)  // добавляем жизненный цикл заявок
                                    .Include(r => r.User)         // добавляем данные о пользователях
                                    .OrderByDescending(r => r.Lifecycle.Opened); // упорядочиваем по дате по убыванию   

            return View(requests.ToList());
        }
        // всі заявки
        [Authorize(Roles = "admin")]
       
        public IActionResult RequestList()
        {
            User user = _context.User.Where(m => m.Email == HttpContext.User.Identity.Name).FirstOrDefault();

            var requests = _context.Application

                                    .Include(r => r.Lifecycle)  // добавляем жизненный цикл заявок
                                    .Include(r => r.User)         // добавляем данные о пользователях
                                    .OrderByDescending(r => r.Lifecycle.Opened); // упорядочиваем по дате по убыванию   

            return View(requests.ToList());
        }
        //Видалення заявки користувачем
        
        public IActionResult Delete(int id)
        {
            Application request = _context.Application.Find(id);
            // получаем текущего пользователя
            User user = _context.User.Where(m => m.Email == HttpContext.User.Identity.Name).First();
            if (request != null && request.UserId == user.Id && (request.Status==1||request.Status==4))
            {
                Lifecycle lifecycle = _context.Lifecycle.Find(request.LifecycleId);
                _context.Lifecycle.Remove(lifecycle);
                _context.SaveChanges();
            }
            else if (request != null)
            {
                Lifecycle lifecycle = _context.Lifecycle.Find(request.LifecycleId);
                _context.Lifecycle.Remove(lifecycle);
                _context.SaveChanges();
                return RedirectToAction("RequestList");
            }
            return RedirectToAction("Index");
        }
        //Видалення заявки адміном
   

     
      

        // GET: Applications/Create
        [Authorize]
        public IActionResult Create()
        {
            User user = _context.User.Where(m => m.Email == HttpContext.User.Identity.Name).FirstOrDefault();
            if (user != null)
            {

                return View();
            }
            return NotFound();
        }

        // POST: Applications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Application request)
        {   // получаем текущего пользователя
            User user = _context.User.Where(m => m.Email == HttpContext.User.Identity.Name).FirstOrDefault();
            if (user == null)
            {
                return RedirectToAction("LogOff", "Account");
            }
            if (ModelState.IsValid)
            {
                // указываем статус Открыта у заявки
                request.Status = (int)RequestStatus.Open;
                //получаем время открытия
                DateTime current = DateTime.Now;

                //Создаем запись о жизненном цикле заявки
                Lifecycle newLifecycle = new Lifecycle() { Opened = current };
                request.Lifecycle = newLifecycle;

                //Добавляем жизненный цикл заявки
                _context.Lifecycle.Add(newLifecycle);

                // указываем пользователя заявки
                request.UserId = user.Id;

                
                //Добавляем заявку
                _context.Application.Add(request);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(request);
        }

        // GET: Applications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Application.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", application.UserId);
            return View(application);
        }

        // POST: Applications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,Email,Fullname,Main_place_of_work,Position_in_combination,Type,Purpose,Saving_salary,Trip_city,Trip_country,Institution,Start_date,End_date,Itinerary,App_transport_Id,Payment,App_fundation_Id,InstitutionLocation")] Application application)
        {
            if (id != application.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(application);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationExists(application.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", application.UserId);
            return View(application);
        }
        [HttpGet]
        [Authorize(Roles = "admin")]
        public ActionResult ChangeStatus()
        {
            // получаем текущего пользователя
            User user = _context.User.Where(m => m.Email == HttpContext.User.Identity.Name).First();
            if (user != null)
            {
                var requests = _context.Application.Include(r => r.User)
                                    .Include(r => r.Lifecycle)
                                   
                                    .Where(r => r.Status != (int)RequestStatus.Closed);
                return View(requests);
            }
            return NotFound();
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult ChangeStatus(int requestId, int status)
        {
            User user = _context.User.Where(m => m.Email == HttpContext.User.Identity.Name).First();
            if (user == null)
            {
                return NotFound();
            }

            Application req = _context.Application.Find(requestId);
            if (req != null)
            {
                req.Status = status;
                Lifecycle lifecycle = _context.Lifecycle.Find(req.LifecycleId);

                if (status == (int)RequestStatus.Checking)
                {
                    lifecycle.Checking = DateTime.Now;
                }
                else if (status == (int)RequestStatus.Closed)
                {
                    lifecycle.Closed = DateTime.Now;
                }
                else if (status == (int)RequestStatus.Rejected)
                {
                    lifecycle.Closed = DateTime.Now;
                }
                _context.Entry(lifecycle).State = EntityState.Modified;
                _context.Entry(req).State = EntityState.Modified;
                _context.SaveChanges();
            }

            return RedirectToAction("ChangeStatus");
        }

            private bool ApplicationExists(int id)
        {
            return _context.Application.Any(e => e.Id == id);
        }
    }
}
