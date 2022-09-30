using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartphoneShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<User>>>> GetUsers()
        {
            var result = await _userService.GetUsers();
            return Ok(result);
        }

        

        [HttpDelete("admin/{id}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<User>>>> DeleteUser(int id)
        {
            var result = await _userService.DeleteUser(id);
            return Ok(result);
        }

        [HttpPost("admin"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<User>>>> AddUser(User user)
        {
            var result = await _userService.AddUser(user);
            return Ok(result);
        }

        [HttpPut("admin"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<User>>>> UpdateUser(User user)
        {
            var result = await _userService.UpdateUser(user);
            return Ok(result);
        }
    }
}
