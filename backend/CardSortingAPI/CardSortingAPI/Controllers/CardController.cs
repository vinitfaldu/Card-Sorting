using CardSortingAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardSortingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardSortingService _cardSortingService;

        public CardController(ICardSortingService cardSortingService)
        {
            _cardSortingService = cardSortingService;
        }

        [HttpPost]
        public IActionResult SortCards([FromBody] List<string> cards)
        {
            var sortedCards = _cardSortingService.SortCards(cards);
            return Ok(sortedCards);
        }

        [HttpGet]
        public IActionResult GetCards()
        {
            return Ok("test");
        }
    }
}
