using Microsoft.EntityFrameworkCore;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Infrastructures.Repositories
{
    public class CommentRepository(DbContext _context) : GenericRepository<Comment>(_context)
    {
        
        public async Task<IEnumerable<Comment>> GetCommentsByProductIdAsync(Guid ProductId)
        {
            return await _dbSet.Where(c =>  c.ProductId == ProductId).ToListAsync();
        }


        public async Task<IEnumerable<Comment>> GetCommentsByUserIdAsync(Guid UserId)
        {
            return await _dbSet.Where(c => c.UserId == UserId).ToListAsync();
        }
    }
}
