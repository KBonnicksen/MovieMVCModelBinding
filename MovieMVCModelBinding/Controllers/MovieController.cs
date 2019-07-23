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
            Movie film = new Movie()
            {
                Title = data["title"],
                Director = data["director"],
                YearReleased = Convert.ToInt32(data["year"]),
                Genre = data["genre"],
                IMDBRating = Convert.ToInt32(data["rating"])
            };
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
                //Add to database
                MovieDB.Add(film);

                //Display thank-you/success message
                ViewData["Success"] = "Student was successfully registered!";
            }
            return View();
        }
    }
}