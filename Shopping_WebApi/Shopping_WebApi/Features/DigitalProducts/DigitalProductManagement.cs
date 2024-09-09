using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.DigitalProducts.Commands;
using Shopping_WebApi.Features.DigitalProducts.Queries;


namespace Shopping_WebApi.Features.DigitalProducts
{
    [Route("api/[controller]")]
    [ApiController]
    public class DigitalProductManagement(ISender _sender) : ControllerBase
    {
        [HttpGet]
        [Route("DigitalProducts")]
        public async Task<IActionResult> DigitalProducts()
        {
            var query = new DigitalProductsQuery();
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpGet]
        [Route("DigitalProduct")]
        public async Task<IActionResult> DigitalProduct(DigitalProductQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddDigitalProduct")]
        public async Task<IActionResult> AddDigitalProduct(AddDigitalProductCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateDigitalProduct")]
        public async Task<IActionResult> UpdateDigitalProduct(UpdateDigitalProductCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteDigitalProduct")]
        public async Task<IActionResult> DeleteDigitalProduct(DeleteDigitalProductCommand command)
        {
            var result = await _sender.Send(command.Id);
            return Ok(result);
        }
    }

}
