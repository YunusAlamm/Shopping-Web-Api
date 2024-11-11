using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.RegisterAndLogin.Commands;
using Shopping_WebApi.Features.RegisterAndLogin.Dto;

namespace Shopping_WebApi.Features.RegisterAndLogin
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDto registerDto)
        {
            var result = await _mediator.Send(new RegisterUserCommand(registerDto));
            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok("User registered successfully");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDto loginDto)
        {
            var token = await _mediator.Send(new LoginUserCommand(loginDto));
            if (token == null)
                return Unauthorized("Invalid login attempt");

            return Ok(new { Token = token });
        }
    }

}
