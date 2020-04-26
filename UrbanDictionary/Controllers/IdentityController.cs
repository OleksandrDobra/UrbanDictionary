using Microsoft.AspNetCore.Mvc;

namespace UrbanDictionary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login()
        {
            return Ok();
        }
        [HttpPost("register")]
        public IActionResult Register()
        {
            return Ok();
        }

    }
}