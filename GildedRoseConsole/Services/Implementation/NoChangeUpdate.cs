using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRoseConsole.Models;
using GildedRoseConsole.Services.Interfaces;

namespace GildedRoseConsole.Services.Implementation
{
    public class NoChangeUpdate : IDailyUpdateService
    {
        public void DailyUpdate(Item item)
        {
        }
    }
}
