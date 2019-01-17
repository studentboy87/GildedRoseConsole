using GildedRoseConsole.Models;

namespace GildedRoseConsole.Services.Interfaces
{
    public interface IAppService
    {
        IDailyUpdateService DailyUpdateServiceCreator(Item item);
        IErrorUpdate ErrorUpdate(Item item);
    }
}
