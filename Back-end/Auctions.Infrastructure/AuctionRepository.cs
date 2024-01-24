using Auctions.Application;
using Auctions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auctions.Infrastructure
{
    public class AuctionRepository : IAuctionRepository
    {
        public void AddAuction(Auction auction)
        {
            throw new NotImplementedException();
        }

        public List<Auction> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Auction> GetByAuctionId(int auctionId)
        {
            throw new NotImplementedException();
        }

        public List<Auction> GetByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public void Update(Auction auction)
        {
            throw new NotImplementedException();
        }
    }
}
