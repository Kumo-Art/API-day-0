using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : ControllerBase
    {
        
         private readonly IMathServices _mathServices;

         //DI, ASP.NET  cores passes in the IMathService that we registered in our program.cs
         //Everytime the controller is caLLE THE FIRST METHOD THAT RUNS IS THE CONSTRUCTOR
         public MathController(IMathServices mathServices)
        {
            _mathServices = mathServices;
        }

        [HttpGet("addition/{numOne}/{numTwo}")]
        
        public IActionResult Addition(int numOne, int numTwo)
        {
            int sum = _mathServices.Addition(numOne, numTwo);
            return Ok(new {numOne, numTwo, Result = sum});
        }
    }
}