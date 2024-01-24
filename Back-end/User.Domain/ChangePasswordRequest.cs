using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain
{
    public class ChangePasswordRequest
    {
        public string id { get; set; }
        public string oldPassword { get; set; }
        public string newPassword { get; set; } 
    }
}
