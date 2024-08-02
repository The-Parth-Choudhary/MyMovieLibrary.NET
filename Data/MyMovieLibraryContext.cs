using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMovieLibrary.Models;

namespace MyMovieLibrary.Data
{
    public class MyMovieLibraryContext : DbContext
    {
        public MyMovieLibraryContext (DbContextOptions<MyMovieLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<MyMovieLibrary.Models.Movie> Movie { get; set; } = default!;
    }
}
