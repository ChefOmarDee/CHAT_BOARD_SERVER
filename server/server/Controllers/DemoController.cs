using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using server.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers
{
 

    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        // GET: api/<DemoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {

            Console.WriteLine("a");
            return new string[] { "omar k", "value2" };
        }

        // GET api/<DemoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Console.WriteLine("b");
            return (id).ToString();
        }

        // POST api/Demo
        [HttpPost()]
        public void Post([FromBody] server.Models.Demo value)
        {

            Console.WriteLine("c");
            Console.WriteLine(value.msg);
            /*JObject o = JObject.Parse(value);
            Console.WriteLine(o.GetType());*/

        }


        // PUT api/<DemoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Demo value)
        {
            Console.WriteLine("d");
        }

        // DELETE api/<DemoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine("e");
        }
    }
}
