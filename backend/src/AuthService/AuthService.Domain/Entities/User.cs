namespace AuthService.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string ExternalId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string ImageUrl { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public User(string externalId, string firstName, string lastName, string username, string email, string imageUrl)
    {
        ExternalId = externalId;
        FirstName = firstName;
        LastName = lastName;
        Username = username;
        Email = email;
        ImageUrl = imageUrl;
        CreatedAt = DateTime.UtcNow;
    }
}