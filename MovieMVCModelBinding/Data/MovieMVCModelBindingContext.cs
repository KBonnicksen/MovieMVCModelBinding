using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieMVCModelBinding.Models
{
    public class MovieMVCModelBindingContext : DbContext
    {
        public MovieMVCModelBindingContext (DbContextOptions<MovieMVCModelBindingContext> options)
            : base(options)
        {
        }

        public DbSet<MovieMVCModelBinding.Models.Movie> Movie { get; set; }
    }
}
