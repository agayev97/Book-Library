using BookLibrary.Application.DTOs.Auth;
using BookLibrary.Application.Interfaces.Services;
using BookLibrary.Domain.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestDto dto)
        {

            var result = await _authService.LoginAsync(dto);
                if (result == null)
                return Unauthorized("Email ve ya sifre sehvdir.");


            return Ok(result);

        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequestDto dto)
        {
            try
            {
                await _authService.RegisterAsync(dto);
                return Ok("Istifadeci ugurla qeydiyatdan kecdi.");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }


        [HttpGet("me")]
        public IActionResult Me()
        {
            return Ok(new
            {
                Id = User.FindFirstValue(ClaimTypes.NameIdentifier),
                UserName = User.Identity!.Name,
                FullName = User.FindFirstValue(ClaimTypes.GivenName),
                Email = User.FindFirstValue(ClaimTypes.Email),
                Phone = User.FindFirstValue(ClaimTypes.MobilePhone),
                Fin = User.FindFirst("fin")?.Value,
                IsActive = User.FindFirst("is_active")?.Value,
                Roles = User.FindAll(ClaimTypes.Role).Select(r => r.Value)
            });
        }
    }
}
