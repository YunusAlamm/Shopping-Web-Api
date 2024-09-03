using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.PhysicalProducts.Commands;
using Shopping_WebApi.Features.PhysicalProducts.Queries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shopping_WebApi.Features.PhysicalProducts
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhysicalProductController(ISender _sender) : ControllerBase
    {
        [HttpGet]
        [Route("PhysicalProducts")]
        public async Task<IActionResult> PhysicalProducts()
        {
            var query = new PhysicalProductsQuery();
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpGet]
        [Route("PhysicalProduct")]
        public async Task<IActionResult> PhysicalProduct(PhysicalProductQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddPhysicalProduct")]
        public async Task<IActionResult> AddPhysicalProduct(AddPhysicalProductCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdatePhysicalProduct")]
        public async Task<IActionResult> UpdatePhysicalProduct(UpdatePhysicalProductCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DeletePhysicalProduct")]
        public async Task<IActionResult> DeletePhysicalProduct(DeletePhysicalProductCommand command)
        {
            var result = await _sender.Send(command.Id);
            return Ok(result);
        }
    }

}
