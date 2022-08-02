using Esourcing.Sourcing.Entities;
using Esourcing.Sourcing.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Esourcing.Sourcing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidController : ControllerBase
    {
        private readonly IBidRepository _bidRepository;
        private readonly ILogger<BidController> _logger;

        public BidController(IBidRepository bidRepository, ILogger<BidController> logger)
        {
            _bidRepository = bidRepository;
            _logger = logger;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Bid),(int)HttpStatusCode.OK)]
        public async Task<IActionResult> SendBid ([FromBody] Bid bid)
        {
            await _bidRepository.SendBid(bid);
            return Ok();
        }

        [HttpGet("GetBidByAuctionId")]
        [ProducesResponseType(typeof(Bid),(int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Bid>>> GetBidByAuctionId(string id)
        {
            IEnumerable<Bid> bids = await _bidRepository.GetBidsByAuctionId(id);
            return Ok(bids);
        }

        [HttpGet("[action]")]
        [ProducesResponseType(typeof(Bid),(int)HttpStatusCode.OK)]
        public async Task<ActionResult<Bid>> GetWinnerBid(string id)
        {
            Bid bid = await _bidRepository.GetWinnerBid(id);
            return Ok(bid);
        }

    }
}
