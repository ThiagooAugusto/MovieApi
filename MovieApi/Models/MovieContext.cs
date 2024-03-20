using Microsoft.EntityFrameworkCore;

namespace MovieApi.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
