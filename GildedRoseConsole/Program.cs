using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using GildedRoseConsole.Models;
using GildedRoseConsole.Services.Implementation;
using GildedRoseConsole.Services.Interfaces;

namespace GildedRoseConsole
{
    public class Program
    {
        private readonly IAppService _appService = new AppService();
        IList<Item> Items;
        IList<string> ApprovedInventory;

        static void Main(string[] args)
        {
            var app = new Program
            {
                Items = new List<Item>
                {
                    new Item {ItemName = "Aged Brie", SellIn = 1, Quality = 1},
                    new Item {ItemName = "Backstage passes", SellIn = -1, Quality = 2},
                    new Item {ItemName = "Backstage passes", SellIn = 9, Quality = 2},
                    new Item {ItemName = "Sulfuras", SellIn = 2, Quality = 2},
                    new Item {ItemName = "Normal Item", SellIn = -1, Quality = 55},
                    new Item {ItemName = "Normal Item", SellIn = 2, Quality = 2},
                    new Item {ItemName = "INVALID ITEM", SellIn = 2, Quality = 2},
                    new Item {ItemName = "Conjured", SellIn = 2, Quality = 2},
                    new Item {ItemName = "Conjured", SellIn = -1, Quality = 5}
                },
                ApprovedInventory =
                    new List<string> { "Aged Brie", "Backstage passes", "Sulfuras", "Normal Item", "Conjured" }
            };
            PrintInventory(app);
            app.UpdateInventory();
            Console.WriteLine("\n Update Run \n");
            PrintInventory(app);
            Console.ReadKey();
        }

        private static void PrintInventory(Program app)
        {
            foreach (var appItem in app.Items)
            {
                var writeLine = string.Concat(appItem.ItemName, " ", appItem.SellInString, " ", appItem.QualityString);
                Console.WriteLine(writeLine);
            }
        }

        public void UpdateInventory()
        {
            foreach (var item in Items)
            {
                if (ApprovedInventory.Contains(item.ItemName))
                {
                    var updateItem = _appService.DailyUpdateServiceCreator(item);
                    updateItem.DailyUpdate(item);
                }
                else
                {
                    var errorItem = _appService.ErrorUpdate(item);
                    errorItem.UnknownItem(item);
                }
            }
        }
    }
}
