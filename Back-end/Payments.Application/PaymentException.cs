using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments.Application
{
    public class PaymentException : Exception
    {
        public int StatusCode { get; }
        public PaymentException(int statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
