using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;

namespace MovieApi.Repositories.Interfaces
{

    public interface IBaseRepository<T>
    {
        //cuidado para não violar o principio ISP
        IEnumerable<T> GetAll();
        T? Get(Expression<Func<T, bool>> predicate);
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
