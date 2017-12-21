using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MoviesMVCTutorial.Models
{
    public class MovieContext  : DbContext
    {
        public MovieContext()
        {
                
        }
        public DbSet<Movie> Movies { get; set; }
    }
}