using AuctionItems.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AuctionItems.Application
{
    public class AuctionItemService : IAuctionItemService
    {
        private readonly IAuctionItemRepository _repository;
        private readonly IMapper _mapper;
        public AuctionItemService(IAuctionItemRepository auctionItemRepository, IMapper mapper)
        {
            _repository = auctionItemRepository;
            _mapper = mapper;
        }

        public void AddAuctionItem(AuctionItemCreateRequest itemRequest)
        {
            var auctionItem = _mapper.Map<AuctionItem>(itemRequest);
            _repository.AddAuctionItem(auctionItem);
        }

        public void DeleteAuctionItem(int id)
        {
            var isItemExist = _repository.IsAuctionItemExist(id);
            if (isItemExist) _repository.DeleteAuctionItem(id);

            throw new AutionItemsException((int)HttpStatusCode.NotFound, $"Can not found item has id: {id}");
        }

        public List<AuctionItem> GetAllAuctionItems()
        {
            var auctionItems = _repository.GetAllAuctionItems();

            if (auctionItems == null || auctionItems.Count == 0) 
                throw new AutionItemsException((int)HttpStatusCode.NotFound, "Auction item list is empty");

            return auctionItems;
        }

        public List<AuctionItem> GetAnnouncementItem()
        {
            var auctionItems = _repository.GetAnnouncementItem();

            if (auctionItems == null || auctionItems.Count == 0)
                throw new AutionItemsException((int)HttpStatusCode.NotFound, "There is no item in announcement");

            return auctionItems;
        }

        public AuctionItem GetAuctionItemById(int id)
        {
            var auctionItem = _repository.GetAuctionItemById(id);

            if (auctionItem == null) 
                throw new AutionItemsException((int)HttpStatusCode.NotFound, $"Can not find auction item has id: {id}");

            return auctionItem;
        }

        public List<AuctionItem> GetAuctionItemsAuctioning()
        {
            var auctionItems = _repository.GetAuctionItemsAuctioning();

            if (auctionItems == null || auctionItems.Count == 0)
                throw new AutionItemsException((int)HttpStatusCode.NotFound, "There is no item which is auctioning");

            return auctionItems;
        }

        public List<AuctionItem> GetAuctionItemsCompleted()
        {
            var auctionItems = _repository.GetAuctionItemsCompleted();

            if (auctionItems == null || auctionItems.Count == 0)
                throw new AutionItemsException((int)HttpStatusCode.NotFound, "There is no item which is completed");

            return auctionItems;
        }

        public void UpdateAuctionItem(AuctionItemUpdateRequest updateRequest)
        {
            var isItemUpdate = _repository.IsAuctionItemExist(updateRequest.AuctionId);
            if (!isItemUpdate)
                throw new AutionItemsException((int)HttpStatusCode.NotFound, $"Can not found item has id: {updateRequest.AuctionId}");

            var auctionItem = _mapper.Map<AuctionItem>(updateRequest);
            _repository.UpdateAuctionItem(auctionItem);
        }
    }
}
