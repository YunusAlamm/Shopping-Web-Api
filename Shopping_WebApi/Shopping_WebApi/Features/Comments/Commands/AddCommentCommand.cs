using MediatR;

namespace Shopping_WebApi.Features.Comments.Commands
{
    public class AddCommentCommand: IRequest<string>
    {
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public string Content { get; set; }
        public int? Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }



}
