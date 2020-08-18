using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using test2.Models;

namespace test2.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Zavods.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Zavod zavod)
        {
            db.Zavods.Add(zavod);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }

}
