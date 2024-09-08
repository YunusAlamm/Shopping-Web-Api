using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Infrastructure.Repositories;

namespace Shopping_WebApi.Infrastructures.Repositories
{
    public interface ICommentRepository: IGenericRepository<Comment>
    {
        Task<IEnumerable<Comment>> GetCommentsByProductIdAsync(Guid ProductId);
        Task<IEnumerable<Comment>> GetCommentsByUserIdAsync(Guid UserId);
    }
}