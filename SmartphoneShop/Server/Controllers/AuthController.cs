using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace SmartphoneShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegister userRegister)
        {
            var response = await _authenticationService.Register(new User
            {
                Email = userRegister.Email
            }, 
            userRegister.Password);

            if(!response.Success){ return BadRequest(response); }
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLogin userLogin)
        {
            var response = await _authenticationService.Login(userLogin.Email, userLogin.Password);
            if (!response.Success) { return BadRequest(response); }
            return Ok(response);
        }
        [HttpPost("change-password"),Authorize]
        public async Task<ActionResult<ServiceResponse<bool>>> ChangePassword([FromBody] string newPassword)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _authenticationService.ChangePassword(int.Parse(userId), newPassword);

            if (!response.Success) { return BadRequest(response); }
            return Ok(response);
        }
    }
}
