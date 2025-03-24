﻿using BookLibrary.Application.DTOs.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.Users
{
    public class UpdateUserDto : UpdateMemberDto
    {
        public int Id { get; set; }
        public DateTime MembershipEndDate { get; set; }

    }
}
