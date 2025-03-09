using BookLibrary.Application.DTOs.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.Users
{
    public class CreateUserDto : CreateMemberDto
    {
        public DateTime MembershipStartDate { get; set; } = DateTime.Now;
        public DateTime MembershipEndDate {  get; set; } 
    }
}
