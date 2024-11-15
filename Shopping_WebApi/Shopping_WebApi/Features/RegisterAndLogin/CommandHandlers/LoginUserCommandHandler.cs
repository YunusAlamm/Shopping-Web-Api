using MediatR;
using Microsoft.AspNetCore.Identity;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.RegisterAndLogin.Commands;
using Shopping_WebApi.Infrastructures.JwtTokenService;

namespace Shopping_WebApi.Features.RegisterAndLogin.CommandHandlers
{
    public class LoginUserCommandHandler(
        UserManager<User> _userManager,
        SignInManager<User> _signInManager,
        ITokenService _tokenService
        ) : IRequestHandler<LoginUserCommand, string>
    {
        public async Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.LoginDto.Email);
            if (user == null) 
                return null;

            var result = await _signInManager.CheckPasswordSignInAsync(user, request.LoginDto.Password, false);
            if (!result.Succeeded) 
                return null;

            var roles = await _userManager.GetRolesAsync(user);
            return _tokenService.GenerateToken(user, roles); 
        }
    }
}
