using Microsoft.AspNetCore.Mvc;
using API.Services;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisorsController : Controller
    {
        [HttpGet]
        public IActionResult GetDivisorsAndPrimeDivisors([FromQuery] int number)
        {
            DivisorsService service = new DivisorsService();
            return Ok(service.Result(number));
        } 
    }
}
