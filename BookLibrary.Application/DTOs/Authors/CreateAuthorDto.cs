﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.Authors
{
    public class CreateAuthorDto
    {
        public string FullName {  get; set; }
        public string Biography {  get; set; }
    }
}
