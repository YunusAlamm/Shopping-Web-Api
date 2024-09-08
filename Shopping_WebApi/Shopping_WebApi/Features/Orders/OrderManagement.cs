using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.Orders.Commands;
using Shopping_WebApi.Features.Orders.Queries;


namespace Shopping_WebApi.Features.Orders
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderManagement(ISender _sender) : ControllerBase
    {
        [HttpGet]
        [Route("Orders")]
        public async Task<IActionResult> Orders()
        {
            var query = new OrdersQuery();
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpGet]
        [Route("Order")]
        public async Task<IActionResult> Order(OrderQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddOrder")]
        public async Task<IActionResult> AddOrder(AddOrderCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateOrder")]
        public async Task<IActionResult> UpdateOrder(UpdateOrderCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteOrder")]
        public async Task<IActionResult> DeleteOrder(DeleteOrderCommand command)
        {
            var result = await _sender.Send(command.Id);
            return Ok(result);
        }
    }

}
