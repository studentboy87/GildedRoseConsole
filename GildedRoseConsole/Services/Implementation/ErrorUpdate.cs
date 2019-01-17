using GildedRoseConsole.Models;
using GildedRoseConsole.Services.Interfaces;

namespace GildedRoseConsole.Services.Implementation
{
    public class ErrorUpdate : IErrorUpdate
    {
        public void UnknownItem(Item item)
        {
            item.ItemName = "NO SUCH ITEM";
            item.Quality = null;
            item.SellIn = null;
        }
    }
}
