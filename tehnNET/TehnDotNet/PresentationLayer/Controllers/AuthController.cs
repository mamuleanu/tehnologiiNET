using Microsoft.AspNetCore.Mvc;
using TehnDotNet.ApplicationLayer.Dto;
using TehnDotNet.ApplicationLayer.Services.Interfaces;

namespace TehnDotNet.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto dto)
    {
        var result = await _authService.RegisterAsync(dto);

        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }

        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto dto)
    {
        var token = await _authService.LoginAsync(dto);

        if (token == null)
        {
            return Unauthorized();
        }

        return Ok(new { Token = token });
    }
}
