using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wolves.Models;

namespace Wolves.Controllers
{
    public class WolfController : Controller    
    {
        private WolfContext dbContext;

        // Dependency inject our service
        public WolfController (WolfContext context) {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Wolves = dbContext.Wolves.ToList();
            return View();
        }

        [Route("create")]
        [HttpPost]
        public IActionResult Create(Wolf wolf)
        {
            if(ModelState.IsValid){
                dbContext.Add(wolf);
                dbContext.SaveChanges();
                Console.WriteLine($"{wolf.Name} {wolf.Type} {wolf.DOB}");
                return Redirect("/");
            } else {
                ViewBag.Wolves = dbContext.Wolves.ToList();
                return View("Index", wolf);
            }
        }

    }
}
