using Ardalis.Specification;

namespace SensorX.Domain.AggregatesModel.UserAggregate.Specifications;

public class UserByUsernameSpec : Specification<User>
{
    public UserByUsernameSpec(string username)
    {
        Query.Where(u => u.Username == username);
    }
}
