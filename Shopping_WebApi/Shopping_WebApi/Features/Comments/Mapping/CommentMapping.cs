using AutoMapper;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.Comments.Dto;

namespace Shopping_WebApi.Features.Comments.Mapping
{
    public class CommentMapping: Profile
    {
        public CommentMapping() 
        {
            CreateMap<Comment,CommentDto>();
            CreateMap<CommentDto, Comment>();
        }
    }
}
