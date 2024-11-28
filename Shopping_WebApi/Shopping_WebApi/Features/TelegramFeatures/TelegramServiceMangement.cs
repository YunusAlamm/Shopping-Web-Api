using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.TelegramFeatures.Commands;

namespace Shopping_WebApi.Features.TelegramFeatures
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelegramServiceMangement(ISender _sender) : ControllerBase
    {
        [HttpPost]
        [Route("newproduct")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> NewProduct(NewProductCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }
    }


}
