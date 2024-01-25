using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionItems.Domain
{
    public class AuctionItemCreateRequest
    {
        public string LicensePlate { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal MinAmountIncrease { get; set; }
        public string KindOfCar { get; set; }
        public string LicenseType { get; set; }
        public string City { get; set; }
        public bool Status { get; set; }
    }
}
