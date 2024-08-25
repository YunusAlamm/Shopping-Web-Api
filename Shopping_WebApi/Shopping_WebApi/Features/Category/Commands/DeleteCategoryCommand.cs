using MediatR;

namespace Shopping_WebApi.Features.Category.Commands
{
    public class DeleteCategoryCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
