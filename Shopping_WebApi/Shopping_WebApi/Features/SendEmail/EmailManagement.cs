using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.SendEmail.Commands;

namespace Shopping_WebApi.Features.SendEmail
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailManagement(ISender _sender) : ControllerBase
    {
        [HttpPost]
        [Route("SendEmail")]
        public async Task<IActionResult> Send(SendEmailCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }
    }
}
