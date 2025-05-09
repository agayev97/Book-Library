using BookLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.Interfaces.Services
{
    public interface IJwtService
    {
        string GenerateToken(User user, List<string> roles);
    }
}
