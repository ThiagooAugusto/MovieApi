using MovieApi.Context;
using MovieApi.Models;
using MovieApi.Repositories.Interfaces;

namespace MovieApi.Repositories
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieContext context) : base(context)
        {
        }

        public IEnumerable<Movie> GetMoviesByCategory(int id)
        {
            return GetAll().Where(x => x.CategoryId == id);
        }
    }
}
