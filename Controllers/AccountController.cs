using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using BusinessTrip.Models;
using BusinessTrip.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace BusinessTrip.Controllers
{
    public class AccountController : Controller
    {
        private BusinessTripContext db;
        public AccountController(BusinessTripContext _db)
        {
            db = _db;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = db.User
                    .Include(u => u.Role)
                    .FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
                if (user != null)
                {
                    await Authenticate(user); // аутентификация
                    return RedirectToAction("Index", "Users");
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
                User user = db.User.FirstOrDefault(u => u.Email == model.Email);
                if (user == null)
                {
                    // добавляем пользователя в бд
                    user = new User
                    {
                        Email = model.Email,
                        Password = model.Password,
                        LastName = model.LastName,
                        FirstName = model.FirstName,
                        FatherName = model.FatherName,
                        RoleId = db.Role.Where(r => r.RoleName == "user").First().Id
                    };
                    Role userRole = db.Role.FirstOrDefault(r => r.RoleName == "user");
                    if (userRole != null)
                        user.Role = userRole;

                    db.User.Add(user);
                    await db.SaveChangesAsync();

                    await Authenticate(user); // аутентификация
                    return RedirectToAction("Index", "Users");
                }
                else
                    ModelState.AddModelError("", "Похибка паролю та(чи) логіну");
            }
            return View(model);
        }

        private async Task Authenticate(User user)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, db.Role.FirstOrDefault(r=>r.Id==user.RoleId).RoleName)
        };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
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