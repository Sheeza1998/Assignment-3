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
        private MovieListContext Context { get; set; }

        public HomeController(MovieListContext movielist)
        {
            Context = movielist;
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
        public IActionResult Movies(Class apps)
        {
            Context.Classes.Add(apps);

            Context.SaveChanges();
            return View("Confirmed", apps);
        }

        //Controls the movies entered page
        public IActionResult MoviesEntered()
        {
            return View(Context.Classes);
        }

        //Takes to confirmation page
        public IActionResult Confirmed()
        {
            return View();
        }

        //Edits the record
        public IActionResult Edit(int movieId)
        {
            Class movie = Context.Classes.Where(e => e.MovieId == movieId).FirstOrDefault();

            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Class movie, int movieId)
        {
            Context.Classes.Where(e => e.MovieId == movieId).FirstOrDefault().Category = movie.Category;
            Context.Classes.Where(e => e.MovieId == movieId).FirstOrDefault().Title = movie.Title;
            Context.Classes.Where(e => e.MovieId == movieId).FirstOrDefault().Director = movie.Director;
            Context.Classes.Where(e => e.MovieId == movieId).FirstOrDefault().Edited = movie.Edited;
            Context.Classes.Where(e => e.MovieId == movieId).FirstOrDefault().Year = movie.Year;
            Context.Classes.Where(e => e.MovieId == movieId).FirstOrDefault().Rating = movie.Rating;
            Context.Classes.Where(e => e.MovieId == movieId).FirstOrDefault().Lent = movie.Lent;
            Context.Classes.Where(e => e.MovieId == movieId).FirstOrDefault().Notes = movie.Notes;

            Context.SaveChanges();
            return RedirectToAction("MoviesEntered");
        }

        //Deletes the record

        [HttpPost]
        public IActionResult Delete(int movieID)
        {
            Class movie = Context.Classes.Where(e => e.MovieId == movieID).FirstOrDefault();
            Context.Classes.Remove(movie);
            Context.SaveChanges();
            return RedirectToAction("MoviesEntered");
        }
        //private IActionResult View(Action<Class> addApplication) { 
        //    throw new NotImplementedException();
        //}
   

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
