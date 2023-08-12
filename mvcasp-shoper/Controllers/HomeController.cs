// ===========================================================================
/// <summary>
/// HomeController.cs
/// mvcasp-shoper
/// created by Mehrdad Soleimanimajd on 02.08.2023
/// </summary>
/// <created>ʆϒʅ, 02.08.2023</created>
/// <changed>ʆϒʅ, 12.08.2023</changed>
// ===========================================================================

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvcasp_shoper.Data;
using mvcasp_shoper.Models;
using System.Diagnostics;
using System.Text.Encodings.Web;

namespace mvcasp_shoper.Controllers
{
    public class HomeController: Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public async Task<IActionResult> Index(string searchField, int howMany = 3)
        {
            var todos = from m in _context.Todos select m;
            if (!(Int16.MaxValue < howMany))
            {
                ViewData["soMany"] = howMany;
            }
            if (!String.IsNullOrEmpty(searchField))
            {
                todos = todos.Where(item => item.Name.Contains(searchField));
            }
            return View(await todos.ToArrayAsync());
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