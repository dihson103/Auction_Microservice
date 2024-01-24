using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
