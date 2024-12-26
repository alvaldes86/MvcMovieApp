using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovieApp.Data;
using MvcMovieApp.Models;
using System.Diagnostics;

namespace MvcMovieApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MvcMovieAppContext _context;

        public HomeController(MvcMovieAppContext context)
        {
           _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Movie.ToListAsync());
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
