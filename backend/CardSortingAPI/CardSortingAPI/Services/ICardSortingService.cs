using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardSortingAPI.Services
{
    public interface ICardSortingService
    {
        public List<string> SortCards(List<string> cards);
    }
}
