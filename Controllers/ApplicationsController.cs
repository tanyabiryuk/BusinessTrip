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
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Rotativa.AspNetCore;

namespace BusinessTrip.Controllers
{
    public class ApplicationsController : Controller
    {
        private readonly BusinessTripContext _context;

        public ApplicationsController(BusinessTripContext context)
        {
            _context = context;
        }

        // Просмотр подробных сведений о заявке
        public ActionResult Details(int id)
        {
            Application application = _context.Application.Find(id);

            if (application != null)
            {

                return PartialView("_Details", application);
            }
            return View("Index");
        }

        public IActionResult ExportToPDF()
        {
            return new ViewAsPdf();
     
        }

        public IActionResult GenerateApp(int id)
        {
            Application request = _context.Application.Find(id);
          

            if (request != null)
            {



                //return PartialView("GenerateApp", request);
                return new ViewAsPdf("GenerateApp", request) {

                    PageSize = Rotativa.AspNetCore.Options.Size.A4
                };
            }
            return View("RequestList");
        }
        //заявки користувача
        [Authorize]
       
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
            else if (request != null&&user.RoleId==1)
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
        public IActionResult Create(Application request, 
            List<string> Transport, string OtherTransport, 
            List<string> Foundation, string OtherFoundation)
        {   // получаем текущего пользователя
            User user = _context.User.Where(m => m.Email == HttpContext.User.Identity.Name).FirstOrDefault();
            if (user == null)
            {
                return RedirectToAction("Logout", "Account");
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

                string temp;
                foreach(string f in Foundation)
                {
                    temp = f;
                    if (f == "Інше") temp = OtherFoundation;
                    if(!_context.Foundation.Select(n=>n.Trip_Foundation).Contains(temp))
                    {
                        _context.Foundation.Add(new Foundation { Trip_Foundation = temp });
                        _context.SaveChanges();
                    }
                    _context.App_Fundation.Add(new App_Fundation
                    {
                        ApplicationId = request.Id,
                        FundationId = _context.Foundation.FirstOrDefault(n => n.Trip_Foundation == temp).Id
                    });
                    _context.SaveChanges();
                }

                foreach(string t in Transport)
                {
                    temp = t;
                    if (t == "Інше") temp = OtherTransport;
                    if (!_context.Transport.Select(n => n.TransportType).Contains(temp))
                    {
                        _context.Transport.Add(new Transport { TransportType = temp });
                        _context.SaveChanges();
                    }
                    _context.App_Transport.Add(new App_Transport
                    {
                        ApplicationId = request.Id,
                        TransportId = _context.Transport.FirstOrDefault(n => n.TransportType == temp).Id
                    });
                    _context.SaveChanges();
                }

                request.App_fundation_Id = request.Id;

                request.App_transport_Id = request.Id;

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
