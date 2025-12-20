using BookLibrary.Application.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.Auth
{
    public class LoginResponseDto
    {
        public string Token { get; set; } = null!;
        
    }
}
