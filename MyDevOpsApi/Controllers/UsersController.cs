using Microsoft.AspNetCore.Mvc;
using MyDevOpsApi.Services;
[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    private readonly UserService _service;

    public UsersController(UserService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_service.GetUsers());
    }
}
