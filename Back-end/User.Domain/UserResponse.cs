﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain
{
    public class UserResponse
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; } = true;
    }
}
