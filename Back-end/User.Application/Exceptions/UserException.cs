using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Application.Exceptions
{
    public class UserException : Exception
    {
        public int StatusCode { get; }
        public UserException(int statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
