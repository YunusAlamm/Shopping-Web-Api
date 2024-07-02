using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Data;

namespace Shopping_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
       private readonly Shopping_StoreContext _storeContext;

        public UserController(Shopping_StoreContext storeContext)
        {
            _storeContext = storeContext;
        }
    }
}
