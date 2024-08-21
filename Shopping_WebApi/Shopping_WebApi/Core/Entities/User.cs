using Microsoft.AspNetCore.Identity;

namespace Shopping_WebApi.Core.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

    }
}
