using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FileApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpGet]
        public IActionResult Healthcheck()
        {
            return Ok("File Controller os up");
        }
    

        // GET api/<FileController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FileController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FileController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FileController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
