using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FelipeBastosAnotherProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FelipeBastosAnotherProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly FelipeBastosAnotherProjectContext _context;

        public HomeController(FelipeBastosAnotherProjectContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Placar.OrderByDescending(x => x.pontos).Take(10).ToListAsync());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Aplicação AV 3 - Desenvolvimento de Sistemas";

            return View();
        }

        public IActionResult Contact()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
