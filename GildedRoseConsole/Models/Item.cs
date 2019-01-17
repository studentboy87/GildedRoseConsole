namespace GildedRoseConsole.Models
{
    public class Item : ItemBase
    {
        public int? SellIn { get; set; }
        public int? Quality { get; set; }
        public string SellInString => SellIn != null ? SellIn.ToString() : "";
        public string QualityString => Quality != null ? Quality.ToString() : "";
    }
}
