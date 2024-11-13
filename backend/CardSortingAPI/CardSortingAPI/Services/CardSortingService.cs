using CardSortingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardSortingAPI.Services
{
    public class CardSortingService : ICardSortingService
    {
        public List<string> SortCards(List<string> cards)
        {
            return cards
                .OrderBy(card => CardConstants.SpecialCards.Contains(card) ? CardConstants.SpecialCards.IndexOf(card) : int.MaxValue)
                .ThenBy(card => !CardConstants.SpecialCards.Contains(card) && CardConstants.SuitOrder.Contains(card[^1].ToString()) ? CardConstants.SuitOrder.IndexOf(card[^1].ToString()) : int.MaxValue)
                .ThenBy(card => !CardConstants.SpecialCards.Contains(card) ? CardConstants.RankOrder.IndexOf(card.Length == 3 ? card[..2] : card[0].ToString()) : int.MaxValue)
                .ToList();
        }
    }
}
