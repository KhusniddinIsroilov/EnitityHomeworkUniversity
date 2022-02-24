using EnitityHomeworkUniversity.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EnitityHomeworkUniversity.Data.Repositories
{
#pragma warning disable

    public abstract class GenericRepository<T> : IGenericRepsitory<T> where T : class
    {
        SmartDbContext _smartDbContext;
        private DbSet<T> dbSet { get; set; }

        public GenericRepository()
        {
            _smartDbContext = new SmartDbContext();
            this.dbSet = _smartDbContext.Set<T>();
        }


        public async Task<T> CreateAsync(T entity)
        {
           var entry = await dbSet.AddAsync(entity);
           await _smartDbContext.SaveChangesAsync();

            return entry.Entity;
                    

        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
          var result =  await  dbSet.FirstOrDefaultAsync(predicate);
            if(result == null)
                return false;
            dbSet.Remove(result);
          await  _smartDbContext.SaveChangesAsync();

            return true;

        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            Expression<Func<T, bool>> pred = pred => true;

            return predicate == null ? dbSet : dbSet.Where(pred);
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var entry = dbSet.Update(entity);
            await _smartDbContext.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
