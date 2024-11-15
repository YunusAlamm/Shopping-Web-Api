using MediatR;
using Microsoft.AspNetCore.Identity;
using Shopping_WebApi.Features.RegisterAndLogin.Dto;

namespace Shopping_WebApi.Features.RegisterAndLogin.Commands
{
    public class RegisterUserCommand(
        RegisterUserDto userDto
        ) : IRequest<IdentityResult>
    {
        public RegisterUserDto UserDto { get; set; } = userDto;
    }
}
