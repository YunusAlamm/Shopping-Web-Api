using MediatR;

namespace Shopping_WebApi.Features.Category.Commands
{
    public class AddCategoryCommand: IRequest<bool>
    {
        public string Name { get; set; }
    }
}
