using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVCModelBinding.Models
{
    public class CustomMovieYearAttribute : RangeAttribute
    {
        /// <summary>
        /// Sets the Range attribute to accept only years that movies 
        /// have been made. Min value: 1800, Max value: current year
        /// </summary>
        public CustomMovieYearAttribute() : base(typeof(DateTime),
            1800.ToString(),
            DateTime.Now.ToShortDateString())
        { }
    }
}
