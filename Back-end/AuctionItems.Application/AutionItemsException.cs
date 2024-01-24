using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionItems.Application
{
    public class AutionItemsException : Exception
    {
        public int StatusCode { get; }
        public AutionItemsException(int statusCode, string message) : base(message) 
        {
            StatusCode = statusCode;
        }
    }
}
