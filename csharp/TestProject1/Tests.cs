using System;
using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SellInDecreases()
        {
            IList<Item> items = new List<Item>{
                new Item {Name = "Bananas", SellIn = 10, Quality = 20}
            };

            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(9, items[0].SellIn);
        }
        
        [Test]
        public void SellInCannedBeans()
        {
            IList<Item> items = new List<Item>{
                new Item {Name = "Canned Beans", SellIn = 10, Quality = 20}
            };

            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(10, items[0].SellIn);
        }
        
        
        
        [Test]
        public void QualityGeneralDecrease()
        {
            IList<Item> items = new List<Item>{
                new Item {Name = "General Case", SellIn = 10, Quality = 40}
            };

            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(39, items[0].Quality);
        }
        
        [Test]
        public void QualityGeneralExpiredDecrease()
        {
            IList<Item> items = new List<Item>{
                new Item {Name = "General Case", SellIn = -1, Quality = 40}
            };

            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(38, items[0].Quality);
        }
        
        [Test]
        public void QualityBrieIncrease()
        {
            IList<Item> items = new List<Item>{
                new Item {Name = "Aged Brie", SellIn = 10, Quality = 40}
            };

            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(41, items[0].Quality);
        }
        
        [Test]
        public void QualityBrieExpiredIncrease()
        {
            IList<Item> items = new List<Item>{
                new Item {Name = "Aged Brie", SellIn = -1, Quality = 40}
            };

            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(42, items[0].Quality);
        }
        
        [Test]
        public void QualityBrieExpiredIncrease2()
        {
            IList<Item> items = new List<Item>{
                new Item {Name = "Aged Brie", SellIn = -1, Quality = 49}
            };

            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
        }
        
        [Test]
        public void QualityBrieMax()
        {
            IList<Item> items = new List<Item>{
                new Item {Name = "Aged Brie", SellIn = 10, Quality = 49}
            };

            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
        }
        
        [Test]
        public void QualityCannedBeansStatic()
        {
            IList<Item> items = new List<Item>{
                new Item {Name = "Canned Beans", SellIn = 10, Quality = 40}
            };

            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(40, items[0].Quality);
        }
        
        
        [Test]
        public void QualityBakedDecrease()
        {
            IList<Item> items = new List<Item>{
                new Item {Name = "Baked Sourdough Bread", SellIn = 3, Quality = 6}
            };

            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(4, items[0].Quality);
        }
        
        [Test]
        public void QualityBakedDecrease1()
        {
            IList<Item> items = new List<Item>{
                new Item {Name = "Baked Sourdough Bread", SellIn = 3, Quality = 1}
            };

            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }
        
        [Test]
        public void QualityBakedExpiredDecrease()
        {
            IList<Item> items = new List<Item>{
                new Item {Name = "Baked Sourdough Bread", SellIn = 0, Quality = 6}
            };

            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(2, items[0].Quality);
        }
        
        [Test]
        public void QualityBakedExpiredDecrease1()
        {
            IList<Item> items = new List<Item>{
                new Item {Name = "Baked Sourdough Bread", SellIn = 0, Quality = 3}
            };

            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }
        
        
    }
}