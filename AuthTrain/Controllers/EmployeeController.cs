using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AuthTrain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        [HttpGet("")]
        [Authorize]
        public async Task<IActionResult> GetData()
        {
            return Ok("U made it");
        }
    }
}
