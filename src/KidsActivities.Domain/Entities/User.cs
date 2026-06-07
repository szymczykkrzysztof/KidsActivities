using KidsActivities.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace KidsActivities.Domain.Entities;

public class User : IdentityUser<Guid>
{
    private protected User()
    {
    }

    public static User Create(string firstName, string lastName, string email, Role role)
    {
        return new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            UserName = email,
            Role = role
        };
    }

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public Role Role { get; set; }
}