using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardSortingAPI.Models
{
    public class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }
    }

    public static class CardConstants
    {
        public static readonly List<string> SpecialCards = new List<string> { "4T", "2T", "ST", "PT", "RT" };
        public static readonly List<string> SuitOrder = new List<string> { "T", "D", "S", "C", "H" };
        public static readonly List<string> RankOrder = new List<string> { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
    }

}
