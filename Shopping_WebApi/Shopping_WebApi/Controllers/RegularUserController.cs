using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping_WebApi.Data;
using Shopping_WebApi.Models;

namespace Shopping_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegularUserController : ControllerBase
    {
       private readonly Shopping_StoreContext _storeContext;

        public RegularUserController(Shopping_StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        [HttpPost]
        public async Task<IActionResult> Register(string username, string password,string address, string postcode, string phonenumber, string email)
        {
            if(await _storeContext.RegularUsers.AnyAsync(x=> x.Name == username)) {
                return Ok("user already exists, please log-in");
            }
            else
            {
                _storeContext.Add(new RegularUser { Name = username, Password = password, Address = address, PostCode = postcode, PhoneNumber = phonenumber,Email = email });
                await _storeContext.SaveChangesAsync();
                return Ok("user registered!");
            }

        }
    }
}
