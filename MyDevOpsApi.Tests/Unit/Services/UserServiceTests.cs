using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyDevOpsApi.Services;

namespace MyDevOpsApi.Tests.Unit.Services;

[TestClass]

public class UserServiceTests
{
    [TestMethod]
    public void GetUsers_ShouldReturnTwoInitailUsers()
    {
        var service = new UserService();
        var users = service.GetUsers();

        Assert.AreEqual(2, users.Count ,"The service should return exactly 2 users.");
        Assert.AreEqual("Rishav", users[0].Name);
    }
}