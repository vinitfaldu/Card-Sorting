using CardSortingAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CardSortingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        [HttpPost]
        public IActionResult SortCards([FromBody] List<string> cards)
        {
            var sortedCards = cards.OrderBy(card =>
            {
                // Check if the card is a special card
                if (CardConstants.SpecialCards.Contains(card))
                {
                    // Give special cards the highest priority
                    return CardConstants.SpecialCards.IndexOf(card) - 1000;
                }

                // Extract rank and suit from the card
                var rank = card.Length > 2 ? card.Substring(0, card.Length - 1) : card[0].ToString();
                var suit = card[^1].ToString();

                // Compute sort order for non-special cards
                int suitOrder = CardConstants.SuitOrder.IndexOf(suit);
                int rankOrder = CardConstants.RankOrder.IndexOf(rank);

                return suitOrder * 100 + rankOrder; // Combine suit and rank for comparison
            }).ToList();

            return Ok(sortedCards);
        }

        [HttpGet]
        public IActionResult GetCards()
        {
            return Ok("test");
        }
    }
}
