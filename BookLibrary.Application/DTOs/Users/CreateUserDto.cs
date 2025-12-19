<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

=======
﻿
>>>>>>> 30a375c37371e3ee478ce5c054475b0d9c23f210
namespace BookLibrary.Application.DTOs.Users
{
    public class CreateUserDto 
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? FIN { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime MembershipStartDate { get; set; } = DateTime.Now;
        public DateTime MembershipEndDate {  get; set; } 
    }
}
