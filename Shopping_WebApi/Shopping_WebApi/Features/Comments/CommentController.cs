﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.Comments.Commands;
using Shopping_WebApi.Features.Comments.Queries;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;



namespace Shopping_WebApi.Features.Comments
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController(ISender _sender) : ControllerBase
    {
        
        [HttpGet]
        [Route("CommentsByProductId")]
        public async Task<IActionResult> CommentsByProductId(GetCommentsByProductIdQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }

        
        [HttpGet]
        [Route("CommentsByUserId")]
        public async Task<IActionResult> CommentsByUserId(GetCommentsByUserIdQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpGet]
        [Route("Comment")]
        public async Task<IActionResult> Comment(GetCommentByIdQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }


        [HttpPost]
        [Route("AddComment")]
        public async Task<IActionResult> AddComment(AddCommentCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        
        [HttpPut]
        [Route("UpdateComment")]
        public async Task<IActionResult> UpdateComment(UpdateCommentCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        
        [HttpDelete]
        [Route("DeleteComment")]
        public async Task<IActionResult> DeleteComment(DeleteCommentCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }
    }
}
