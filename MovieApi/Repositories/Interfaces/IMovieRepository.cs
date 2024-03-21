using MovieApi.Models;
namespace MovieApi.Repositories.Interfaces
{
    public interface IMovieRepository:IBaseRepository<Movie>
    {
        IEnumerable<Movie> GetMoviesByCategory(int id);
    }
}
