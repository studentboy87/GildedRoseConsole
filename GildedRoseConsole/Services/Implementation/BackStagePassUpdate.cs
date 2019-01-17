using GildedRoseConsole.Models;
using GildedRoseConsole.Services.Interfaces;

namespace GildedRoseConsole.Services.Implementation
{
    public class BackStagePassUpdate : IDailyUpdateService
    {
        public void DailyUpdate(Item item)
        {
            const int maxQuality = 50;
            item.SellIn--;
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn <= 5)
            {
                item.Quality = item.Quality + 3;
            }
            else if (item.SellIn <= 10)
            {
                item.Quality = item.Quality + 2;
            }
            else if (item.Quality < maxQuality)
            {
                item.Quality++;
            }
        }
    }
}
