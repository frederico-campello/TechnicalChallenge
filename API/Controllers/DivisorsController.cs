using Microsoft.AspNetCore.Mvc;
using API.Services;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisorsController : Controller
    {
        [HttpPost]
        public IActionResult GetDivisorsAndPrimeDivisors([FromBody] int number)
        {
            DivisorsService service = new DivisorsService();
            return Ok(service.Result(number));
        } 
    }
}
