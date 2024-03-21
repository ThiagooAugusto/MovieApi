using MovieApi.Context;
using MovieApi.Models;
using MovieApi.Repositories.Interfaces;

namespace MovieApi.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MovieContext context) : base(context)
        {
        }
    }
}
