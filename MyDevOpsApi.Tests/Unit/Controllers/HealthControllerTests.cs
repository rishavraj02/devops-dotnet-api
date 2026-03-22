using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using MyDevOpsApi.Controllers;

namespace MyDevOpsApi.Tests.Unit.Controllers;

[TestClass]
public class HealthControllerTests
{
    [TestMethod]
    public void Get_ReturnHealthyMessage()
    {
        var controller = new HealthController();
        var result = controller.Get() as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual("Healthy", result.Value);
    }
}