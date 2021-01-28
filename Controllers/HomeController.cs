using Assignment_3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Controls the homepage
        public IActionResult Index()
        {
            return View();
        }

        //Controls the Podcast Page
        public IActionResult Podcast()
        {
            return View();
        }

        //Controls the Get/Post Movies Page
        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }

        [HttpPost]

        //Excluing the movie Independence Day
        public IActionResult Movies(Class apps)
        {
            if (apps.Title != "Independence Day") {
                TempStorage.AddApplication(apps);
            }
            return RedirectToAction("MoviesEntered");
        }

        //Controls the movies entered page
        public IActionResult MoviesEntered()
        {
            return View(TempStorage.Applications);
        }

        private IActionResult View(Action<Class> addApplication)
        {
            throw new NotImplementedException();
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
