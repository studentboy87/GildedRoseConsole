using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseConsole
{
    public class Item
    {
        public string ItemName { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
    }
}
