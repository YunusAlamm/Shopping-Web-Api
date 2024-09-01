using MediatR;

namespace Shopping_WebApi.Features.Comments.Commands
{
    public class UpdateCommentCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public int? Rating { get; set; }
        public bool IsApproved { get; set; }
        public DateTime UpdatedAt { get; set; }
    }



}
