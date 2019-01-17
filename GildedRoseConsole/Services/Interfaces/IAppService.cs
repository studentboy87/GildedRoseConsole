using System.Threading.Tasks;
using GildedRoseConsole.Models;

namespace GildedRoseConsole.Services.Interfaces
{
    public interface IAppService
    {
        IDailyUpdateService DailyUpdateServiceCreator(Item item);
        void ErrorUpdate(Item item);
    }
}
