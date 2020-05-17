using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Linq;
using System.Threading.Tasks;
using BusinessTrip.Models;
using BusinessTrip.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusinessTrip.Controllers
{
    public class UsersController : Controller
    {
        BusinessTripContext _db;

        public UsersController(BusinessTripContext db)
        {
            _db = db;
        }
        [Authorize]
        //дані про користувача
        public IActionResult Index() => View(_db);


        //список всіх користувачів 
        [Authorize(Roles = "admin")]
        public IActionResult UsersList() => View(_db.User.ToList());

        //відредагувати дані користувача
        public async Task<IActionResult> Edit(int id)
        {
            User user = await _db.User.FirstOrDefaultAsync(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            EditUserViewModel model = new EditUserViewModel
            {
                Id = user.Id,
                LastName = user.LastName,
                FirstName = user.FirstName,
                FatherName = user.FatherName
            };
            return View(model);
        }

        [HttpPost]
        [Authorize]
        //відредагувати дані користувача
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _db.User.FirstOrDefaultAsync(u => u.Id == model.Id);
                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.FatherName = model.FatherName;
                    user.LastName = model.LastName;

                    _db.User.Update(user);
                    try
                    {
                        _db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        ModelState.AddModelError(string.Empty, e.Message);
                    }
                    if (((ClaimsIdentity)User.Identity).Claims
                    .Where(c => c.Type == ClaimTypes.Role)
                    .Select(c => c.Value).Where(r => r == "admin").Count() != 0) { return RedirectToAction("UsersList"); ; }
                    else { return RedirectToAction("Index"); }
                    
                }
            }
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        //видалити користувача
        public async Task<ActionResult> Delete(string id)
        {
            User user = await _db.User.FirstOrDefaultAsync(u => u.Id.ToString() == id);
            if (user != null)
                try
                {
                    _db.User.Remove(user);
                    _db.SaveChanges();
                }
                catch (Exception e)
                {
                    ModelState.AddModelError(string.Empty, e.Message);
                }
            return RedirectToAction("UsersList");
        }

        [Authorize]
        //змінити пароль користувача
        public async Task<IActionResult> ChangePassword(int id)
        {
            User user = await _db.User.FirstOrDefaultAsync(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            ChangePasswordViewModel model = new ChangePasswordViewModel { Id = user.Id, Email = user.Email };
            return View(model);
        }

        [HttpPost]
        [Authorize]
        //змінити пароль користувача
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _db.User.FirstOrDefaultAsync(u => u.Id == model.Id);
                if (user != null)
                {
                    if (user.Password == model.OldPassword)
                    {
                        user.Password = model.NewPassword;
                        _db.User.Update(user);
                        try
                        {
                            _db.SaveChanges();
                        }
                        catch (Exception e)
                        {
                            ModelState.AddModelError(string.Empty, e.Message);
                        }
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Користувача не знайдено");
                }
            }
            return View(model);
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult CreateUser()
        {
           
            SelectList roles = new SelectList(_db.Role, "Id", "RoleName");
            ViewBag.Roles = roles;
            return View();
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                _db.User.Add(user);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            
            SelectList roles = new SelectList(_db.Role, "Id", "RoleName");
            ViewBag.Roles = roles;

            return View(user);
        }

        //////редагувати роль
         
        [Authorize(Roles = "admin")]
        public IActionResult EditRole()
        {
            // получаем текущего пользователя
            User user = _db.User.Where(m => m.Email == HttpContext.User.Identity.Name).First();
            if (user != null)
            {
                // var userRole = user.RoleId; 
                // var allRoles = _db.Role.ToList();
                //var users = _db.User.Include(r => r.Role);

                var users = _db.User.Include(r => r.Role);
                                  
                return View(users);

                
            }
            return NotFound();
        }

       
        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult EditRole(int userId, int roleId)
        {
            User user = _db.User.Where(m => m.Email == HttpContext.User.Identity.Name).First();
            if (user == null)
            {
                return NotFound();
            }
            User user1 = _db.User.Find(userId);
            if (user1 != null)
            {

                user1.RoleId = roleId;



                _db.Entry(user1).State = EntityState.Modified;
                _db.SaveChanges();
            }

            return RedirectToAction("EditRole");
        }
        //[Authorize(Roles = "admin")]
        //public async Task<IActionResult> EditRole(string userId)
        //{
        //    // получаем пользователя
        //    User user = _db.User.FirstOrDefault(u=>u.Id.ToString()==userId);
        //    if (user != null)
        //    {
        //        // получем список ролей пользователя
        //        var userRole = user.RoleId; 
        //        var allRoles = _db.Role.ToList();
        //        ChangeRoleViewModel model = new ChangeRoleViewModel
        //        {
        //            UserId = user.Id,
        //            UserEmail = user.Email,
        //            UserRoleId = userRole,
        //            AllRoles = allRoles
        //        };
        //        return View(model);
        //    }

        //    return NotFound();
        //}

        //[Authorize(Roles = "admin")]
        //[HttpPost]
        //public async Task<IActionResult> EditRole(int userId, string role)
        //{
        //    // получаем пользователя
        //    User user = _db.User.FirstOrDefault(u=>u.Id == userId);
        //    if (user != null)
        //    {
        //        // получаем роль
        //        var changedRoleId = _db.Role.FirstOrDefault(r => r.RoleName == role ).Id;
        //        // получаем все роли
        //        var allRoles = _db.Role.ToList();

        //        user.RoleId = changedRoleId;
        //        _db.Update(user);

        //        return RedirectToAction("UserList");
        //    }

        //    return NotFound();
        //}
    }
}