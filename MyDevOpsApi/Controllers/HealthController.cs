using Microsoft.AspNetCore.Mvc;
using MyDevOpsApi.Services;
[ApiController]
[Route("health")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Healthy");
    }
}