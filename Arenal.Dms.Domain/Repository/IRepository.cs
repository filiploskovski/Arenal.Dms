using System.Collections.Generic;
using System.Threading.Tasks;

namespace Arenal.Dms.Domain.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task AddRange(List<T> entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
        Task DeleteRange(List<T> entity);
        



    }
}