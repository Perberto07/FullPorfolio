﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp.Shared.DTOs.Auth
{
    public class LoginRequestDto
    {
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
