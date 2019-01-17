using GildedRoseConsole.Models;
using GildedRoseConsole.Services.Interfaces;

namespace GildedRoseConsole.Services.Implementation
{
    public class AppService : IAppService
    {
        public IDailyUpdateService DailyUpdateServiceCreator(Item item)
        {
            if (item.ItemName.Contains("Sulfuras"))
            {
                return new NoChangeUpdate();
            }
            else if (item.ItemName.Contains("Aged Brie"))
            {
                return new AgedBrieUpdate();
            }
            else if (item.ItemName.Contains("Backstage passes"))
            {
                return new BackStagePassUpdate();
            }
            else if (item.ItemName.Contains("Conjured"))
            {
                return new StandardItemUpdate(2);
            }
            else
            {
                return new StandardItemUpdate();
            }
        }

        public IErrorUpdate ErrorUpdate(Item item)
        {
            return new ErrorUpdate();
        }
    }
}
