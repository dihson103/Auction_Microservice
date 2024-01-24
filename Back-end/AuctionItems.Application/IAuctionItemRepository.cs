using AuctionItems.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionItems.Application
{
    public interface IAuctionItemRepository
    {
        List<AuctionItem> GetAllAuctionItems();
        List<AuctionItem> GetAuctionItemsAuctioning();
        List<AuctionItem> GetAuctionItemsCompleted();
        List<AuctionItem> GetAnnouncementItem();
        AuctionItem GetAuctionItemById(int id);
        void AddAuctionItem(AuctionItem auctionItem);
        void DeleteAuctionItem(int id);
        void UpdateAuctionItem(AuctionItem auctionItem);
    }
}
