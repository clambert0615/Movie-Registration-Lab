using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieRegistration.Models;

namespace MovieRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public static List<Movie> Movies = new List<Movie>
        {
            new Movie(1, "Forrest Gump", "Drama", new DateTime(1999, 01, 01), "Tom Hanks, Sally Field", "John Smith"),
            new Movie(2, "The Hangover", "Comedy", new DateTime(2013, 01, 01), "Bradley Cooper, Mike Tyson", "Pete Smith")
        };

        public IActionResult Index()
        {
            int index = Convert.ToInt32(RouteData.Values["id"]);
            int nextIndex = index + 1;

            if (nextIndex >= Movies.Count)
            {
                nextIndex = 0;
            }

            int prevIndex = index - 1;

            if (prevIndex < 0)
            {
                prevIndex = Movies.Count - 1;
            }

            StoreFront storeFront = new StoreFront();
            storeFront.Index = index;
            storeFront.NextIndex = nextIndex;
            storeFront.PrevIndex = prevIndex;
            storeFront.Movie = Movies[index];

            return View(storeFront);
        }
        /*
        public IActionResult Index(Movie movie)
        {
            List<Movie> Movies = new List<Movie>();
            Movies.Add(new Movie(1, "Forrest Gump", "Drama", new DateTime(1999, 01, 01), "Tom Hanks, Sally Field", "John Smith"));
            Movies.Add(new Movie(2, "The Hangover", "Comedy", new DateTime(2013, 01, 01), "Bradley Cooper, Mike Tyson", "Pete Smith"));

            return View(Movies);
        }
        */


        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Result(Movie movie)
        {
            Movies.Add(movie);

            return View(movie);
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
