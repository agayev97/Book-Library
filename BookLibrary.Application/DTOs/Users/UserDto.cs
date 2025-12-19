<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.Users
{
    public class UserDto
=======
﻿
namespace BookLibrary.Application.DTOs.Users
{
    public class UserDto 
>>>>>>> 30a375c37371e3ee478ce5c054475b0d9c23f210
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? FIN { get; set; }
        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime MembershipStartDate {  get; set; }
        public DateTime MembershipEndDate { get; set;}
    }
}
