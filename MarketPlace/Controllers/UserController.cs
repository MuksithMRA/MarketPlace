using MarketPlace.Dtos;
using MarketPlace.Dtos.Requests;
using MarketPlace.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        public IActionResult Login([FromBody] LoginRequest loginRequest)
        {
            ;
            return Ok(_userService.Login(loginRequest));

        }

   
        [HttpGet("{id}") , Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            return Ok(user);
        }
    }
}
