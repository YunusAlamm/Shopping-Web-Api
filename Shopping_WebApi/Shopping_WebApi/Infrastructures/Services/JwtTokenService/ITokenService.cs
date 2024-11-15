using Shopping_WebApi.Core.Entities;

namespace Shopping_WebApi.Infrastructures.Services.JwtTokenService
{
    public interface ITokenService
    {
        string GenerateToken(User user, IList<string> roles);
    }
}
