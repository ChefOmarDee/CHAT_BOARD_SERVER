using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using server.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using server.HelperFunctions;
using System.Runtime.InteropServices.ObjectiveC;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers
{
 

    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        // GET: api/<DemoController>
        [HttpGet]
        public List<StoredJson> Get()
        {

            return (JsonFileUtils.getHandler());

        }

        // GET api/<DemoController>/5
        /*[HttpGet("{id}")]
        public List<Demo> Get(int id)
        {
            List <Demo> omar=new List <Demo> ();
            omar.Add(new Demo() 
            { 
                msg="his",
                name="hi"
            });
            return omar;
        }*/

        // POST api/Demo
        [HttpPost()]
        public void Post([FromBody] Demo value)
        {

            Console.WriteLine("c");
            Console.WriteLine(value.msg);
            JsonFileUtils.jsonEditor(value);
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
            Console.WriteLine(id);
            JsonFileUtils.jsonDeleter(id);

        }
    }
}
