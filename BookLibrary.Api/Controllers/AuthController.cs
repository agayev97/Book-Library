using BookLibrary.Application.DTOs.Auth;
using BookLibrary.Application.Interfaces.Services;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestDto dto)
        {
            var result = await _authService.LoginAsync(dto);
            return Ok(result);

        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequestDto dto)
        {
            await _authService.RegisterAsync(dto);
            return Ok("Istifadeci ugurla qeydiyatdan kecdi.");
        }
    }
}
