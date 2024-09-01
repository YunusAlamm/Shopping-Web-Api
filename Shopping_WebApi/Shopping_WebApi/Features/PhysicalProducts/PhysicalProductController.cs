using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shopping_WebApi.Features.PhysicalProducts
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhysicalProductController : ControllerBase
    {
        // GET: api/<PhysicalProductController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PhysicalProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PhysicalProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PhysicalProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PhysicalProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
