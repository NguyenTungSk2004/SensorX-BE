using SensorX.Domain.SeedWork;

namespace SensorX.Domain.AggregatesModel.UserAggregate;

public class User(string username, string email, string passwordHash, UserId id) : Entity<UserId>(id), ICreationTrackable, IUpdateTrackable, IAggregateRoot
{
    public string Username { get; private set; } = username;
    public string Email { get; private set; } = email;
    public string PasswordHash { get; private set; } = passwordHash;

    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }

    public void UpdatePassword(string newPasswordHash)
    {
        PasswordHash = newPasswordHash;
    }
}
