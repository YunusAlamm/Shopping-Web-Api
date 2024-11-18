using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.Categories.Queries;
using Shopping_WebApi.Features.Category.Commands;



namespace Shopping_WebApi.Features.Category
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryManagement(ISender _sender) : ControllerBase
    {
        
        [HttpGet]
        [Route("Categories")]
        [Authorize(Roles = "admin,costumer")]
        public async Task<IActionResult> Categories()
        {
            var query = new CategoriesQuery();
            var result = await _sender.Send(query);
            return Ok(result);
        }

        
        [HttpGet]
        [Route("Category")]
        [Authorize(Roles = "admin,costumer")]
        public async Task<IActionResult> Category(CategoryQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }

        
        [HttpPost]
        [Route("AddCategory")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> AddCategory(AddCategoryCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        
        [HttpPut]
        [Route("UpdateCategory")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        
        [HttpDelete]
        [Route("DeleteCategory")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteCategory(DeleteCategoryCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }
    }
}
