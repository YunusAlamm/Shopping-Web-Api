using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.CartProduct.Commands;
using Shopping_WebApi.Features.CartProducts.Queries;
using Shopping_WebApi.Features.Carts.Commands;


namespace Shopping_WebApi.Features.CartProducts
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "costumer")]
    public class CartProductManagement(ISender _sender) : ControllerBase
    {
        
        [HttpGet]
        [Route("CartProducts")]
        public async Task<IActionResult> CartProducts()
        {
            var query = new CartProductsQuery();
            var result = await _sender.Send(query);
            return Ok(result);
            
        }

        
        [HttpGet]
        [Route("CartProduct")]
        public async Task<IActionResult> CartProduct(CartProductQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }

        
        [HttpPost]
        [Route("AddCartProduct")]
        public async Task<IActionResult> AddCartProduct(AddCartProductCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        
        [HttpPut]
        [Route("UpdateCartProduct")]
        public async Task<IActionResult> UpdateCartProduct(UpdateCartProductCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        
        [HttpDelete]
        [Route("DeleteCartProduct")]
        public async Task<IActionResult> DeleteCartProduct(DeleteCartProductCommand command)
        {
            var result  = await _sender.Send(command);
            return Ok(result);
        }
    }
}
