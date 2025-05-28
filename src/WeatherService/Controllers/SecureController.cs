namespace WeatherService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SecureController : ControllerBase
{
    [HttpGet("public")]
    public IActionResult Public() => Ok("This is a public endpoint");

    [Authorize]
    [HttpGet("protected")]
    public IActionResult Protected() => Ok("This is a protected endpoint");

    [Authorize(Roles = "admin")]
    [HttpGet("admin")]
    public IActionResult AdminOnly() => Ok("Admin role required");

    [Authorize(Policy = "AdminOnly")]
    [HttpGet("policy")]
    public IActionResult PolicyProtected() => Ok("Policy-based access");
}