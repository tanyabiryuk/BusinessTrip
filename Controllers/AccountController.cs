using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BusinessTrip.Models;
using BusinessTrip.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace BusinessTrip.Controllers
{
    public class AccountController : Controller
    {
        private BusinessTripContext db;
        public AccountController(BusinessTripContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Login(LoginModel model)
        {
            
            if (ModelState.IsValid)
            {

                if (db.User.Where(u => u.Email == model.Email && u.Password == model.Password).ToList().Count != 0)
                {
                    await Authenticate(model.Email); 

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Похибка паролю та(чи) логіну");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                if (db.User.Where(user=>user.Email==model.Email).ToList().Count == 0)
                {
                    // добавляем пользователя в бд
                    db.User.Add(new User
                    {
                        Email = model.Email,
                        Password = model.Password,
                        LastName = model.LastName,
                        FirstName = model.FirstName,
                        FatherName = model.FatherName,
                        RoleId = db.Role.Where(r => r.RoleName == "user").First().Id
                    });
                    try
                    {
                        db.SaveChanges();
                    }
                    catch(Exception e)
                    { throw e; }

                    await Authenticate(model.Email); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Похибка паролю та(чи) логіну");
            }
            return View(model);
        }

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}