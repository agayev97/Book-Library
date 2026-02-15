using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.Users
{
    public class CreateUserDto 
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? FIN { get; set; } = null!;
        public bool IsActive { get; set; } = true;
        public DateTime MembershipStartDate { get; set; } = DateTime.Now;
        public DateTime MembershipEndDate {  get; set; } 
    }
}
