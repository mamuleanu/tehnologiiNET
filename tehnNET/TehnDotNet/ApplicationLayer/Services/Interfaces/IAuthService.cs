using Microsoft.AspNetCore.Identity;
using TehnDotNet.ApplicationLayer.Dto;

namespace TehnDotNet.ApplicationLayer.Services.Interfaces;

public interface IAuthService
{
    Task<IdentityResult> RegisterAsync(RegisterDto dto);
    Task<string?> LoginAsync(LoginDto dto);
}
