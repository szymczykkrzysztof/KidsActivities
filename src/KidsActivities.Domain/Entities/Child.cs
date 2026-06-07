namespace KidsActivities.Domain.Entities;

public class Child : User
{
    public DateOnly DateOfBirth { get; private set; }
    public Guid ParentId { get; private set; }
    public User Parent { get; private set; } = null!;

    private Child()
    {
    }

    public static Child Create(string firstName, string lastName, string email, DateOnly dateOfBirth, Guid parentId)
    {
        return new Child()
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            UserName = email,
            Role = Enums.Role.Child,
            DateOfBirth = dateOfBirth,
            ParentId = parentId
        };
    }
}