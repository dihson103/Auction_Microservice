using AuctionItems.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionItems.Application
{
    public interface IAuctionItemService
    {
        List<AuctionItem> GetAllAuctionItems();
        List<AuctionItem> GetAuctionItemsAuctioning();
        List<AuctionItem> GetAuctionItemsCompleted();
        List<AuctionItem> GetAnnouncementItem();
        AuctionItem GetAuctionItemById(int id);
        void AddAuctionItem(AuctionItemCreateRequest itemRequest);
        void DeleteAuctionItem(int id);
        void UpdateAuctionItem(AuctionItemUpdateRequest updateRequest);
    }
}
