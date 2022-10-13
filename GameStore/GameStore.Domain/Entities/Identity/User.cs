using Microsoft.AspNetCore.Identity;

namespace GameStore.Domain.Entities.Identity
{
    public class User : IdentityUser<int> 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
