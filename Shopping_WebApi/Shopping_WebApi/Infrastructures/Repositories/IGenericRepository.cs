using System.Linq.Expressions;

namespace Shopping_WebApi.Infrastructure.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<bool> ExistByConditions(Expression<Func<T, bool>> predicate);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(Guid id);
        
    }


}
