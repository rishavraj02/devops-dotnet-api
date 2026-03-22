using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using MyDevOpsApi.Controllers;
using MyDevOpsApi.Services;
using System.Collections.Generic;
using MyDevOpsApi.Models;

namespace MyDevOpsApi.Tests.Unit.Controllers;

[TestClass]
public class UsersControllerTests
{
    [TestMethod]
    public void Get_ReturnOkWithUserList()
    {
        var service = new UserService();
        var userscontroller = new UsersController(service);

        var result = userscontroller.Get() as OkObjectResult;

        Assert.IsNotNull(result);
        var userList = result.Value as List<User>;
        Assert.IsNotNull(userList);
        Assert.AreEqual(2, userList.Count);

        
    }
}