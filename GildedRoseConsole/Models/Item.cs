namespace GildedRoseConsole.Models
{
    public class Item : ItemBase
    {
        //try with nullable then remove
        public int? SellIn { get; set; }
        public int? Quality { get; set; }
    }
}
