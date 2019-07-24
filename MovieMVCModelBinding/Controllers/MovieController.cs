using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieMVCModelBinding.Models;

namespace MovieMVCModelBinding.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(IFormCollection data)
        {
            //Validation code here
            try
            {
                Movie film = new Movie()
                {
                    Title = data["title"],
                    Director = data["director"],
                    YearReleased = Convert.ToInt32(data["year"]),
                    Genre = data["genre"],
                    IMDBRating = Convert.ToDouble(data["rating"])
                };

                MovieDB.Add(film);
                ViewData["Success"] = "Movie has been added!";
            }
            catch (Exception)
            {
                ViewData["Error"] = "Whoops, looks like something went wrong! :(";
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddMovieMB()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovieMB(Movie film)
        {
            if (ModelState.IsValid)
            {
                MovieDB.Add(film);

                ViewData["Success"] = "Movie has been added!";
            }
            return View();
        }
    }
}