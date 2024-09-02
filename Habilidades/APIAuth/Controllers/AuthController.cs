using APIAuth.Model;
using APIAuth.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIAuth.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {

        [HttpPost]
        public IActionResult Login([FromBody] LoginModel user)
        {
            JwtTokenService _jwtTokenService = new JwtTokenService();

            var loginResult = _jwtTokenService.GenerateAuthToken(user);

            return loginResult is null ? Unauthorized() : Ok(loginResult);
        }
    }
}
