using MediatR;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Orders()
        {
            var query = new OrdersQuery();
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpGet]
        [Route("Order")]
        [Authorize(Roles = "admin,costumer")]
        public async Task<IActionResult> Order(OrderQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddOrder")]
        [Authorize(Roles = "costumer")]
        public async Task<IActionResult> AddOrder(AddOrderCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateOrder")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdateOrder(UpdateOrderCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteOrder")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteOrder(DeleteOrderCommand command)
        {
            var result = await _sender.Send(command.Id);
            return Ok(result);
        }
    }

}
