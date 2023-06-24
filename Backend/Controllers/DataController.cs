using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/data")]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Replace this with your actual data retrieval logic
            var data = new List<string> { "Data 1", "Data 2", "Data 3" };
            return Ok(data);
        }
    }
}
