using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Arenal.Dms.Domain.Repository
{
    public interface IRepository<T> where T : class
    {
        Task Add(T entity);
        Task AddRange(List<T> entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task DeleteRange(List<T> entity);

        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);

        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<T, bool>> predicate);
    }
}