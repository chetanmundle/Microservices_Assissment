using AuthService.Model;
using AuthService.Service.IService;
using AuthService.Utility;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet("bookAndGetAvailblePartner")]
        //[Authorize(Roles = SD.CustomerRole)]
        public async Task<IActionResult> BookAndGetAvailablePartener()
        {
            var result = await _userService.BookAndGetAvailablePartenerAsync();
            return Ok(result);
        }

        [HttpPost("changeAvailabilityStatus")]
        [Authorize(Roles = $"{SD.CustomerRole}, {SD.DeliveryPartnerRole}")]
        public async Task<IActionResult> ChangeAvailabilityStatus(ChangeAvailabilityReqDto req)
        {
            var result = await _userService.ChangeAvailabilityStatusAsync(req);
            return Ok(result);
        }
    }
}
