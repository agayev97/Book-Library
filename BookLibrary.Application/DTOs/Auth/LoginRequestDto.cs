﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.Auth
{
    public class LoginRequestDto
    {
        public string UserName {  get; set; }
        public string Password { get; set; }

       

    }
}
