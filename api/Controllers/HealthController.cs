using System.Net.Security;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult HealthCheck()
        {
            //This sends a 200 status code string
            return Ok("This API is running");
        }

       [HttpGet("json")]

       public IActionResult HealthCheckJson()
        {
            return Ok(new { Message = "Hello from our API"});
        }

    }
}