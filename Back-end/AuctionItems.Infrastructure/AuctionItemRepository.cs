using AuctionItems.Application;
using AuctionItems.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionItems.Infrastructure
{
    public class AuctionItemRepository : IAuctionItemRepository
    {
        private readonly AuctionItemDbContext _context;
        public AuctionItemRepository(AuctionItemDbContext context)
        {
            _context = context;
        }

        public void AddAuctionItem(AuctionItem auctionItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuctionItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<AuctionItem> GetAllAuctionItems()
        {
            throw new NotImplementedException();
        }

        public List<AuctionItem> GetAnnouncementItem()
        {
            throw new NotImplementedException();
        }

        public AuctionItem GetAuctionItemById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AuctionItem> GetAuctionItemsAuctioning()
        {
            throw new NotImplementedException();
        }

        public List<AuctionItem> GetAuctionItemsCompleted()
        {
            throw new NotImplementedException();
        }

        public void UpdateAuctionItem(AuctionItem auctionItem)
        {
            throw new NotImplementedException();
        }
    }
}
