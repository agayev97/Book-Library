using BookLibrary.Application.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.Interfaces.Services
{
    public interface IAuthService
    {
        Task<LoginResponseDto> LoginAsync(LoginRequestDto loginDto);
        Task RegisterAsync(RegisterRequestDto registerDto);
    }
}
