using Microsoft.EntityFrameworkCore;

namespace Shopping_WebApi.Infrastructure.Repositories
{
    public class GenericRepository<T>(DbContext context) : IGenericRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet = context.Set<T>();

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task InsertAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
             context.Entry(entity).State = EntityState.Modified;
        }

        public async Task DeleteAsync(int id)
        {
            T entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }


}
