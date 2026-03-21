using MyDevOpsApi.Models;

namespace MyDevOpsApi.Services;
public class UserService
{
    private static List<User> users = new()
    {
        new User { Id = 1, Name = "Rishav" },
        new User { Id = 2, Name = "DevOps User" }
    };

    public List<User> GetUsers() => users;
}