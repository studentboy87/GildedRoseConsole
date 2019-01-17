using GildedRoseConsole.Models;
using GildedRoseConsole.Services.Interfaces;

namespace GildedRoseConsole.Services.Implementation
{
    public class AgedBrieUpdate : IDailyUpdateService
    {
        public void DailyUpdate(Item item)
        {
            const int maxQuality = 50;
            item.SellIn--;
            if (item.Quality < maxQuality)
            {
                item.Quality++;
            }
        }
    }
}
