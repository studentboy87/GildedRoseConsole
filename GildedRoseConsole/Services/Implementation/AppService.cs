using System;
using System.Threading.Tasks;
using GildedRoseConsole.Services.Interfaces;

namespace GildedRoseConsole.Services.Implementation
{
    public class AppService :IAppService
    {
        //public AppService(IDailyUpdateService dailyUpdateService)
        //{
        //    _dailyUpdateService = dailyUpdateService;
        //}
        //IDailyUpdateService _dailyUpdateService;

        public IDailyUpdateService DailyUpdateServiceCreator(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
