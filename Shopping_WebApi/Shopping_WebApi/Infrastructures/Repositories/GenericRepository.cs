﻿using Microsoft.EntityFrameworkCore;
using Shopping_WebApi.Infrastructure.Data.DbContext;
using System.Linq.Expressions;

namespace Shopping_WebApi.Infrastructure.Repositories
{
    public class GenericRepository<T>(Shopping_StoreContext _context) : IGenericRepository<T> where T : class
    {
        protected readonly DbSet<T> _dbSet = _context.Set<T>();

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task InsertAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            
            
            
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
             _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            T entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
           await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistByConditions(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

        public async Task<IEnumerable<T>> GetAllByConditionsAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
    }


}
