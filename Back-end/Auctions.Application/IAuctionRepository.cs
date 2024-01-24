using Auctions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctions.Application
{
    public interface IAuctionRepository
    {
        List<Auction> GetAll(); 
        List<Auction> GetByUserId(string userId);
        List<Auction> GetByAuctionId(int auctionId);
        void Update(Auction auction);
        void AddAuction(Auction auction);
    }
}
