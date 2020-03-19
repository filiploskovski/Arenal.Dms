using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Arenal.Dms.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Arenal.Dms.Domain.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DataContext DataContext;
        public Repository(DataContext dataContext)
        {
            DataContext = dataContext;
        }

        public async Task Add(T entity)
        {
            await DataContext.Set<T>().AddAsync(entity);
            await DataContext.SaveChangesAsync();
        }

        public async Task AddRange(List<T> entity)
        {
            await DataContext.Set<T>().AddRangeAsync(entity);
            await DataContext.SaveChangesAsync();

        }

        public async Task Update(T entity)
        {
            DataContext.Set<T>().Update(entity);
            await DataContext.SaveChangesAsync();
        }

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

        public async Task<IEnumerable<T>> GetAll()
        {
            return await DataContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return await DataContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<int> CountAll()
        {
            return await DataContext.Set<T>().CountAsync();
        }

        public async Task<int> CountWhere(Expression<Func<T, bool>> predicate)
        {
            return await DataContext.Set<T>().CountAsync(predicate);
        }
    }
}