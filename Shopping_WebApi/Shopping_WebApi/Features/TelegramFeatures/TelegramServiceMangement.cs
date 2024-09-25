using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.TelegramFeatures.Commands;
using Shopping_WebApi.Infrastructures.TelegramService;

namespace Shopping_WebApi.Features.TelegramFeatures
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelegramServiceMangement(ISender _sender) : ControllerBase
    {
        [HttpPost]
        [Route("newproduct")]
        public async Task<IActionResult> NewProduct(NewProductCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }
    }

    
}
