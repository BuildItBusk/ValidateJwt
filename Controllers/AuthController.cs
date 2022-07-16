using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FunWithAuth.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{

    [HttpGet]
    [Authorize]
    public string Get()
    {
        return "You're authorized to see this.";
    }
}
