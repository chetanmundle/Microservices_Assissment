using AuthService.Model;
using AuthService.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDto model)
        {
            var serviceRes = await _userService.Register(model);
            return Ok(serviceRes);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginReq model)
        {
            var serviceRes = await _userService.Login(model);
            return Ok(serviceRes);
        }
    }
}
