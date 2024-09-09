
    namespace Shopping_WebApi.Core.Entities
    {
        public class Comment
        {
            public Guid Id { get; set; }
            public Guid UserId { get; set; }
            public Guid ProductId { get; set; }
            public string Content { get; set; }
            public int? Rating { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
            public bool IsApproved { get; set; }
            public bool IsDeleted {  get; set; }
        }
    }


