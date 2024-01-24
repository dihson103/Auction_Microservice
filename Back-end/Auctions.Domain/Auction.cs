using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctions.Domain
{
    public class Auction
    {
        [Key, Column(Order = 0)]
        public string UserId { get; set; }
        [Key, Column(Order = 1)]
        public int AuctionItemId { get; set; }
        [Required]
        public decimal AuctionPrice { get; set; }
        [Required]
        public DateTime AuctionDate { get; set; }
    }
}
