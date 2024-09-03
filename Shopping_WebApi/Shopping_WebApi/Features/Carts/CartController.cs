using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.Carts.Commands;
using Shopping_WebApi.Features.Carts.Queries;


namespace Shopping_WebApi.Features.Carts
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController(ISender _sender) : ControllerBase
    {

        [HttpGet]
        [Route("Carts")]
        public async Task<IActionResult> Carts()
        {
            var query = new CartsQuery();
            var result = await _sender.Send(query);
            return Ok(result);
        }


        [HttpGet]
        [Route("Cart")]
        public async Task<IActionResult> Cart(CartQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }


        [HttpPost]
        [Route("AddCart")]
        public async Task<IActionResult> AddCart(AddCartCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }


        [HttpPut]
        [Route("UpdateCart")]

        public async Task<IActionResult> UpdateCart(UpdateCartCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }



        [HttpDelete]
        [Route("DeleteCart")]
        public async Task<IActionResult> DeleteCart(DeleteCartCommand command)
        {
            var result = await _sender.Send(command.Id);
            return Ok(result);
        }
    }
}
