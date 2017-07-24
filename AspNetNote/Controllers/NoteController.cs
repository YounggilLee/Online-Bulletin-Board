using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetNote.DataContext;
using AspNetNote.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetNote.Controllers
{
    public class NoteController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            using (var db = new AspNetNoteContext())
            {
                var list = db.Notes.ToList();
                return View(list);
            }          
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Note model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AspNetNoteContext())
                {
                    db.Notes.Add(model);
                    db.SaveChanges();   //Commit
                    return Redirect("Index");
                }
            }
            return View();
        }

        public IActionResult Edit()
        {
            return View();

        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
