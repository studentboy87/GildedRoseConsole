using System;
using System.Collections.Generic;
using GildedRoseConsole.Services.Interfaces;

namespace GildedRoseConsole.Services.Implementation
{
    public class DailyUpdateService : IDailyUpdateService
    {
        public void DailyInventoryUpdate(List<Item> inventory)
        {
            if (inventory == null || inventory.Count <= 0) return;

            foreach (var item in inventory)
            {

            }

            Console.WriteLine(inventory.ToString());
            Console.ReadLine();
        }
    }
}
