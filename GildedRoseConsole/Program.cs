using System;
using System.Collections.Generic;
using GildedRoseConsole.Services.Implementation;
using GildedRoseConsole.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GildedRoseConsole
{
    public class Program
    {
        private readonly IAppService _appService; 
        IList<Item> Items;

        public Program()
        {
        }

        //public Program(IAppService appService)
        //{
        //    _appService = appService;
        //}

        //private Program()
        //{
        //    throw new NotImplementedException();
        //}

        static void Main(string[] args)
        {
            /*
            //configuring services
            var services = new ServiceCollection()
                .AddTransient<IAppService, AppService>()
                .AddTransient<IDailyUpdateService, DailyUpdateService>();
            //service provider
            var serviceProvider = services.BuildServiceProvider();

            //dependency graph
            var appService = serviceProvider.GetService<IAppService>();

            //appService.RunAsync().Wait();
            */

            var app = new Program
            {
                Items = new List<Item>
                {
                    new Item {ItemName = "Aged Brie", SellIn = 1, Quality = 1},
                    new Item {ItemName = "Backstage passes", SellIn = -1, Quality = 2},
                    new Item{ItemName = "Backstage passes", SellIn = 9, Quality = 2},
                    new Item{ItemName = "Sulfuras", SellIn = 2, Quality = 2},
                    new Item {ItemName = "Normal Item", SellIn = -1, Quality = 55},
                    new Item {ItemName = "Normal Item", SellIn = 2, Quality = 2},
                    new Item {ItemName = "INVALID ITEM", SellIn = 2, Quality = 2},
                    new Item {ItemName = "Conjured", SellIn = 2, Quality = 2},
                    new Item {ItemName = "Conjured", SellIn = -1, Quality = 5}
                }
            };
            Console.WriteLine(app.Items);
            app.UpdateInventory();
            Console.WriteLine(app.Items);
            Console.ReadKey();
        }

        public void UpdateInventory()
        {
            foreach (var item in Items)
            {
                var updateItem = _appService.DailyUpdateServiceCreator(item);
                updateItem
            }
        }

    }
}
