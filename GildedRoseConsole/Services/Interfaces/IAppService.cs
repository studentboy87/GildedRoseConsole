using System.Threading.Tasks;

namespace GildedRoseConsole.Services.Interfaces
{
    public interface IAppService
    {
        IDailyUpdateService DailyUpdateServiceCreator(Item item);
    }
}
