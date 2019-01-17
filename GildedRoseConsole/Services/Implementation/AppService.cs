using System;
using System.Threading.Tasks;
using GildedRoseConsole.Models;
using GildedRoseConsole.Services.Interfaces;

namespace GildedRoseConsole.Services.Implementation
{
    public class AppService :IAppService
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
            else
            {
                return new StandardItemUpdate();
            }

        }

        public void ErrorUpdate(Item item)
        {
            item.ItemName = "NO SUCH ITEM";
            item.Quality = null;
            item.SellIn = null;

        }
    }
}
