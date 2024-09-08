using Microsoft.EntityFrameworkCore;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Infrastructure.Data.DbContext;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Infrastructures.Repositories
{
    public class CommentRepository(Shopping_StoreContext _context) : GenericRepository<Comment>(_context), ICommentRepository
    {
        
        public async Task<IEnumerable<Comment>> GetCommentsByProductIdAsync(Guid productId)
        {
            return await _dbSet.Where(c =>  c.ProductId == productId).ToListAsync();
        }


        public async Task<IEnumerable<Comment>> GetCommentsByUserIdAsync(Guid userId)
        {
            return await _dbSet.Where(c => c.UserId == userId).ToListAsync();
        }


    }
}
