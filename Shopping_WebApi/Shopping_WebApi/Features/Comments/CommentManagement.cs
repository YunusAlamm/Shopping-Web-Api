using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.Comments.Commands;
using Shopping_WebApi.Features.Comments.Queries;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;



namespace Shopping_WebApi.Features.Comments
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentManagement(ISender _sender) : ControllerBase
    {
        
        [HttpGet]
        [Route("CommentsByProductId")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> CommentsByProductId(GetCommentsByProductIdQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }

        
        [HttpGet]
        [Route("CommentsByUserId")]
        [Authorize(Roles = "admin,costumer")]
        public async Task<IActionResult> CommentsByUserId(GetCommentsByUserIdQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpGet]
        [Route("Comment")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Comment(GetCommentByIdQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }


        [HttpPost]
        [Route("AddComment")]
        [Authorize(Roles = "admin,costumer")]
        public async Task<IActionResult> AddComment(AddCommentCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        
        [HttpPut]
        [Route("UpdateComment")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdateComment(UpdateCommentCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        
        [HttpDelete]
        [Route("DeleteComment")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteComment(DeleteCommentCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }
    }
}
