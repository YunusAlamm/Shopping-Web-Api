using MediatR;
using Microsoft.AspNetCore.Identity;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Features.RegisterAndLogin.Commands;

namespace Shopping_WebApi.Features.RegisterAndLogin.CommandHandlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, IdentityResult>
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RegisterUserCommandHandler(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityResult> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                UserName = request.UserDto.Email,
                Email = request.UserDto.Email,
                FirstName = request.UserDto.FirstName,
                LastName = request.UserDto.LastName,
                Address = request.UserDto.Address
            };

            var result = await _userManager.CreateAsync(user, request.UserDto.Password);

            if (!result.Succeeded)
                return result;

            if (!await _roleManager.RoleExistsAsync(request.UserDto.Role))
                await _roleManager.CreateAsync(new IdentityRole(request.UserDto.Role));

            await _userManager.AddToRoleAsync(user, request.UserDto.Role);

            return result;
        }
    }
}
