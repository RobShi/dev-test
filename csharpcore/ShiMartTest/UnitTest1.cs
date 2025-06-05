using System.Collections.Generic;
using System.Linq;
using ShiMartKata;
using Xunit;

namespace ShiMartTest
{
    public class UnitTest1
    {
        [Fact]
        public void VerifyItemBehaviors()
        {
            var testData = new List<(Item item, int expectedSellIn, int expectedQuality)>
            {
                (new Item { Name = "Test", SellIn = 10, Quality = 20 }, 9, 19), (new Item { Name = "Regular Item", SellIn = 5, Quality = 10 }, 4, 9), (new Item { Name = "Aged Brie", SellIn = 5, Quality = 10 }, 4, 11)
            };
            
            var x = testData.Select(t => t.item).ToList();
            x.Add(new Item { Name = "Some Item", SellIn = 10, Quality = 20 });
            x.Add(new Item { Name = "Aged Brie", SellIn = 10, Quality = 20 });
            var y = new Item { Name = "Canned Beans", SellIn = 10, Quality = 20 };
            x.Add(y);
            
            var app = new ShiMart(x);
            app.UpdateQuality();
            
            for (int i = 0; i < testData.Count; i++)
            {
                Assert.Equal(testData[i].expectedSellIn, testData[i].item.SellIn);
                Assert.Equal(testData[i].expectedQuality, testData[i].item.Quality);
            }
            
            Assert.Equal(9, x[3].SellIn);
            Assert.Equal(19, x[3].Quality);
            Assert.Equal(9, x[4].SellIn);
            Assert.Equal(21, x[4].Quality);
            
            Assert.Equal(10, y.SellIn);
            Assert.Equal(20, y.Quality);
        }
    }
}
