using GildedRoseConsole.Models;
using GildedRoseConsole.Services.Interfaces;

namespace GildedRoseConsole.Services.Implementation
{
    public class StandardItemUpdate : IDailyUpdateService
    {
        private readonly int _multiplier;
        const int maxQuality = 50;

        public StandardItemUpdate(int multiplier = 1)
        {
            _multiplier = multiplier;
        }

        public void DailyUpdate(Item item)
        {
            item.SellIn--;
            if (item.Quality > maxQuality)
            {
                item.Quality = maxQuality;
            }
            else if (item.Quality > 0)
            {
                item.Quality -= _multiplier * (item.SellIn < 0 ? 2 : 1);
            }
            else if (item.Quality < 0)
            {
                item.Quality = 0;
            }
        }
    }
}


