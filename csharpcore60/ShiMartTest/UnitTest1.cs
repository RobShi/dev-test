using System.Collections.Generic;
using System.Linq;
using ShiMartKata;
using Xunit;

namespace ShiMartTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var items = new List<Item> { new Item { Name = "Test", SellIn = 10, Quality = 20 } };
            var app = new ShiMart(items);

            app.UpdateQuality();

            Assert.Equal(9, items.First().SellIn);
            Assert.Equal(19, items.First().Quality);
        }

        [Fact]
        public void VerifyBakedItem()
        {
            var items = new List<Item> { new Item { Name = "Baked Sourdough Bread", SellIn = 10, Quality = 20 } };
            var app = new ShiMart(items);

            app.UpdateQuality();

            Assert.Equal(9, items.First().SellIn);
            Assert.Equal(18, items.First().Quality);
        }

        [Fact]
        public void VerifyBakedItemAfterExpiry()
        {
            var items = new List<Item> { new Item { Name = "Baked Sourdough Bread", SellIn = -1, Quality = 20 } };
            var app = new ShiMart(items);

            app.UpdateQuality();

            Assert.Equal(-2, items.First().SellIn);
            Assert.Equal(16, items.First().Quality);
        }
    }
}
