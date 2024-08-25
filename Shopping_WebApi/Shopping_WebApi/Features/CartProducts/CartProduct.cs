using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shopping_WebApi.Features.CartProducts
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartProduct : ControllerBase
    {
        // GET: api/<CartProduct>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CartProduct>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CartProduct>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CartProduct>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CartProduct>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
