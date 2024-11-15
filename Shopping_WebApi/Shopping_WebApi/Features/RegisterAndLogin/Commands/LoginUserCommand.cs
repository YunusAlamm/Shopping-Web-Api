using MediatR;
using Shopping_WebApi.Features.RegisterAndLogin.Dto;

namespace Shopping_WebApi.Features.RegisterAndLogin.Commands
{
    public class LoginUserCommand(
        LoginUserDto loginDto
        ) : IRequest<string>
    {
        public LoginUserDto LoginDto { get; set; } = loginDto;
    }
}
