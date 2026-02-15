using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.Users
{
    public class UpdateUserDto 
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string? FIN { get; set; }
        public bool IsActive { get; set; }
        public DateTime MembershipEndDate { get; set; }

    }
}
