using MediatR;
using Shopping_WebApi.Features.RegisterAndLogin.Dto;

namespace Shopping_WebApi.Features.RegisterAndLogin.Commands
{
    public class LoginUserCommand : IRequest<string>
    {
        public LoginUserDto LoginDto { get; set; }
        public LoginUserCommand(LoginUserDto loginDto)
        {
            LoginDto = loginDto;
        }
    }
}
