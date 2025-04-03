using Microsoft.AspNetCore.Identity;

namespace RegisterUserApp.Models
{
    public class Users :IdentityUser
    {
        public string FullName { get; set; }
    }
}
