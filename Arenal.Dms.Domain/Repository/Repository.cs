using System.Collections.Generic;
using System.Threading.Tasks;
using Arenal.Dms.Domain.Entities;

namespace Arenal.Dms.Domain.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DataContext DataContext;
        public Repository(DataContext dataContext)
        {
            DataContext = dataContext;
        }


        public async Task<T> Add(T entity)
        {
            await DataContext.Set<T>().AddAsync(entity);
            await DataContext.SaveChangesAsync();
        }

        public async Task AddRange(List<T> entity)
        {
            await DataContext.Set<T>().AddRangeAsync(entity);
            await DataContext.SaveChangesAsync();

        }

        //public async Task<T> Update(T entity)
        //{
        //    await DataContext.Set<T>().Update(entity);

        //}

        public async Task Delete(T entity)
        {
            DataContext.Set<T>().Remove(entity);
            await DataContext.SaveChangesAsync();
        }

        public async Task DeleteRange(List<T> entity)
        {
            DataContext.Set<T>().RemoveRange(entity);
            await DataContext.SaveChangesAsync();
        }
    }
}