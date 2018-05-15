using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmmaAPIUseCase.Models;
using EmmaAPIUseCase.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmmaAPIUseCase.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var emmaConnect = new EmmaService();
            var contacts = emmaConnect.GetEmmaMembers();

            return Ok(contacts);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}