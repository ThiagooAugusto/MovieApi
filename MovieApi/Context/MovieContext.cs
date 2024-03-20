using Microsoft.EntityFrameworkCore;
using MovieApi.Models;

namespace MovieApi.Context
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
