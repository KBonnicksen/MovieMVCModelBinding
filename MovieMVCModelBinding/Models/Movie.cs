using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVCModelBinding.Models
{
    /// <summary>
    /// Represents an individual movie
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Unique auto-incrementing ID that identifies
        /// the individual movie
        /// </summary>
        [Key]
        public int MovieID { get; set; }

        /// <summary>
        /// Full title of the movie
        /// </summary>
        [Required(ErrorMessage = "Title is required")]
        [StringLength(80, ErrorMessage = "Title cannot be more than 150 characters")]
        public string Title { get; set; }

        /// <summary>
        /// Full legal name of the film's director
        /// </summary>
        [StringLength(60, ErrorMessage = "Director's name cannot be more than 150 characters")]
        [Required(ErrorMessage = "Director is required")]
        public string Director { get; set; }

        /// <summary>
        /// The four digit year that the film was released
        /// </summary>
        [Display(Name = "Release Year")]
        [CustomMovieYear]
        public int YearReleased { get; set; }

        /// <summary>
        /// General style/motif of the film 
        /// ex. Horror, Western, Romance
        /// </summary>
        [StringLength(30, ErrorMessage = "Genre cannot be more than 30 characters")]
        public string Genre { get; set; }

        /// <summary>
        /// The rating of the film from IMDB's official website
        /// </summary>
        [Display(Name = "IMDB Rating")]
        [Range(.01, 10)]
        public double IMDBRating { get; set; }
    }
}
