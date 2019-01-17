using Xunit.Abstractions;

namespace GildedRoseTests
{
    public class GildedRoseInputTest
    {
        private readonly ITestOutputHelper _output;

        public GildedRoseInputTest(ITestOutputHelper output)
        {
            _output = output;
        }

        //public Program Program;
        //[Fact()]
        //public void NormalItem_DegradeQualityByOne_HasPositiveSellin()
        //{
        //    int originalQuality = 20;
        //    program.Items = new List<Item> { new Item { ItemName = "+5 Dexterity Vest", SellIn = 10, Quality = originalQuality } };
        //    Program.Main();
        //    program.UpdateQuality();

            
        //    Item alteredItem = program.Items[0];

        //    Assert.AreEqual(originalQuality - 1, alteredItem.Quality);
        //    _output.WriteLine(Assert.AreEqual(originalQuality - 1, alteredItem.Quality));
        //}
    }
}
