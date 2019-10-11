using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SimpleClientAuth.Controllers
{
    //[Authorize(Policy = "APIKeyStore")]
    [Route("api/[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("value");
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
