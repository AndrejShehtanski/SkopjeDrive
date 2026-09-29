using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SkopjeDrive.Models;

namespace SkopjeDrive.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var featuredCars = ServicesController.Fleet.Take(3).ToList();
            return View(featuredCars);
        }

        public IActionResult About()
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
