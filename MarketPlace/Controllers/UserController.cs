using MarketPlace.Dtos;
using MarketPlace.Dtos.NewFolder;
using MarketPlace.Dtos.Requests;
using MarketPlace.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("RegisterUser")]
        public IActionResult RegisterUser([FromBody] RegisterRequestDto registerRequest)
        {
             _userService.Register(registerRequest);
            return Ok(new { message = "Registration successful" });

        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            LoginResponse _loginResponse = await _userService.Login(loginRequest);
            if(_loginResponse.StatusCode == StatusCodes.Status401Unauthorized)
            {
                return Unauthorized(_loginResponse);
            }
            else if(_loginResponse.StatusCode == StatusCodes.Status404NotFound) {
                return NotFound(_loginResponse);
            }
            else if(_loginResponse.StatusCode == StatusCodes.Status500InternalServerError)
            {
                return Problem(statusCode:_loginResponse.StatusCode, detail:"Internal Server error");
            }
            else
            {
                return Ok(_loginResponse);
            }

        }

   
        [HttpGet("{id}") , Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme , Roles = "Admin")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            if(user.Id > 0)
            {
                return Ok(user);
            }
            return NotFound();
           
        }
    }
}
