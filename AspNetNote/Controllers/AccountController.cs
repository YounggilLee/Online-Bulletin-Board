using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetNote.Models;
using AspNetNote.DataContext;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetNote.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AspNetNoteContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserId.Equals(model.UserId) 
                                && u.UserPassword.Equals(model.UserPassword));
                    if(user != null)
                    {
                        return RedirectToAction("LoginSuccess", "Home");                       
                    }

                 
                }

                ModelState.AddModelError(string.Empty, "User ID or Password is not correct");
            }
                return View(model);
        }

        // GET: /<controller>/
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AspNetNoteContext())
                {
                    db.Users.Add(model);  //upload data to memory
                    db.SaveChanges();  //save data to sql table
                }
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

    }
}
