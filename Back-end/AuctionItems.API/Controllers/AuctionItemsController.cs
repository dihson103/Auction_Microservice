using AuctionItems.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuctionItems.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionItemsController : ControllerBase
    {
        private readonly IAuctionItemService _service;
        public AuctionItemsController(IAuctionItemService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var auctionItems = _service.GetAllAuctionItems();
            return Ok(auctionItems);
        }

        [HttpGet]
        [Route("announment")]
        public IActionResult GetAnnouncementItem()
        {
            var auctionItems = _service.GetAnnouncementItem();
            return Ok(auctionItems);
        }

        [HttpGet]
        [Route("auctioning")]
        public IActionResult GetAuctionItemsAuctioning()
        {
            var auctionItems = _service.GetAuctionItemsAuctioning();
            return Ok(auctionItems);
        }

        [HttpGet("completed")]
        public IActionResult GetAuctionItemsCompleted()
        {
            var auctionItems = _service.GetAuctionItemsCompleted();
            return Ok(auctionItems);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetAuctionItemsById(int id)
        {
            var auctionItem = _service.GetAuctionItemById(id);
            return Ok(auctionItem);
        }
    }
}
