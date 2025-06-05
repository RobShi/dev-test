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
        public void RegularItem_DecreasesQualityByOne_WhenSellInPositive()
        {
            // Arrange
            var item = new Item { Name = "Regular Item", SellIn = 5, Quality = 10 };
            var items = new List<Item> { item };
            var shimart = new ShiMart(items);

            // Act
            shimart.UpdateQuality();

            // Assert
            Assert.Equal(4, item.SellIn);
            Assert.Equal(9, item.Quality);
        }

        [Fact]
        public void AgedBrie_IncreasesQualityByOne_WhenSellInPositive()
        {
            var item = new Item() { Name = "Aged Brie", SellIn = 5, Quality = 10 };
            var items = new List<Item>() { item };
            var app = new ShiMart(items);
            
            app.UpdateQuality();
            
            Assert.Equal(4, items[0].SellIn);
            Assert.Equal(11, items[0].Quality);
        }

        [Fact]
        public void TestMultipleItemsAtOnce()
        {
            var regularItem = new Item { Name = "Some Item", SellIn = 10, Quality = 20 };
            var agedBrie = new Item { Name = "Aged Brie", SellIn = 10, Quality = 20 };
            var items = new List<Item> { regularItem, agedBrie };
            
            var app = new ShiMart(items);
            app.UpdateQuality();
            
            // regular item goes down
            Assert.Equal(9, regularItem.SellIn);
            Assert.Equal(19, regularItem.Quality);
            
            // aged brie goes up
            Assert.Equal(9, agedBrie.SellIn);
            Assert.Equal(21, agedBrie.Quality);
        }

        [Fact] 
        public void CannedBeans_DoesntChange()
        {
            var beans = new Item { Name = "Canned Beans", SellIn = 10, Quality = 20 };
            List<Item> items = new List<Item>();
            items.Add(beans);
            ShiMart app = new ShiMart(items);
            
            app.UpdateQuality();
            
            Assert.Equal(10, beans.SellIn); // doesn't decrease
            Assert.Equal(20, beans.Quality); // doesn't decrease
        }
    }
}
