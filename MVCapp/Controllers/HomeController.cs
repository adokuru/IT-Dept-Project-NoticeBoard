using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MVCapp.Data;

namespace MVCapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectDbContext _context;

        public HomeController( ProjectDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var project = _context.Projects
               .OrderByDescending(m => m.Id).Take(6);
            
            return View(project);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
