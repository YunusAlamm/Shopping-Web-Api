using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.OrderProducts.Commands;
using Shopping_WebApi.Features.OrderProducts.Queries;


namespace Shopping_WebApi.Features.OrderProducts
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderProductManagement(ISender _sender) : ControllerBase
    {
        [HttpGet]
        [Route("OrderProducts")]
        public async Task<IActionResult> OrderProducts()
        {
            var query = new OrderProductsQuery();
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpGet]
        [Route("OrderProduct")]
        public async Task<IActionResult> OrderProduct(OrderProductQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddOrderProduct")]
        public async Task<IActionResult> AddOrderProduct(AddOrderProductCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateOrderProduct")]
        public async Task<IActionResult> UpdateOrderProduct(UpdateOrderProductCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteOrderProduct")]
        public async Task<IActionResult> DeleteOrderProduct(DeleteOrderProductCommand command)
        {
            var result = await _sender.Send(command.Id);
            return Ok(result);
        }
    }


}
