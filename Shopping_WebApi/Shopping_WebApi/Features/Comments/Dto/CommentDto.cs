namespace Shopping_WebApi.Features.Comments.Dto
{
    public class CommentDto
    {
        
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public string Content { get; set; }
        public int? Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        
    }

}
