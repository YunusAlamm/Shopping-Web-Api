using Shopping_WebApi.Core.Entities;

namespace Shopping_WebApi.Infrastructures.JwtTokenService
{
    public interface ITokenService
    {
        string GenerateToken(User user, IList<string> roles);
    }
}
