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
            _context.AuctionItems.Add(auctionItem);
            _context.SaveChanges();
        }

        public void DeleteAuctionItem(int id)
        {
            var item = GetAuctionItemById(id);
            item.Status = false;

            _context.AuctionItems.Update(item);
            _context.SaveChanges();
        }

        public List<AuctionItem> GetAllAuctionItems()
        {
            var items = _context.AuctionItems.ToList();
            return items;
        }

        public List<AuctionItem> GetAnnouncementItem()
        {
            var currentDate = DateTime.Now;
            var items = _context.AuctionItems
                .Where(item => item.Status == true && item.StartDateTime >= currentDate)
                .ToList();
            return items;
        }

        public AuctionItem GetAuctionItemById(int id)
        {
            var item = _context.AuctionItems.SingleOrDefault(i => i.AuctionId== id);
            return item;
        }

        public List<AuctionItem> GetAuctionItemsAuctioning()
        {
            var currentDate = DateTime.Now;
            var auctionItems = _context.AuctionItems.
                Where(item => item.Status == true && item.StartDateTime<= currentDate && currentDate <= item.EndDateTime)
                .ToList();
            return auctionItems;   
        }

        public List<AuctionItem> GetAuctionItemsCompleted()
        {
            var currentDate = DateTime.Now;
            var auctionItems = _context.AuctionItems.
                Where(item => item.Status == true && item.StartDateTime <= currentDate && currentDate >= item.EndDateTime)
                .ToList();
            return auctionItems;
        }

        public bool IsAuctionItemExist(int id)
        {
            return _context.AuctionItems.Any(i => i.AuctionId== id);
        }

        public void UpdateAuctionItem(AuctionItem auctionItem)
        {
            _context.AuctionItems.Update(auctionItem);
            _context.SaveChanges();
        }
    }
}
