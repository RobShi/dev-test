using System.Collections.Generic;
using System.Linq;
using GildedRoseKata;
using Xunit;

namespace GildedRose.UnitTests;

public class GildedRoseTest
{
    private static IList<Item> CreateItems() => new List<Item>{
        new() {Name = "Bananas", SellIn = 10, Quality = 20},
        new() {Name = "Aged Brie", SellIn = 2, Quality = 1},
        new() {Name = "Eggs", SellIn = 5, Quality = 7},
        new() {Name = "Eggs", SellIn = 12, Quality = 5},
        new() {Name = "Canned Beans", SellIn = 0, Quality = 80},
        new() {Name = "Canned Beans", SellIn = -1, Quality = 80},
        new() {Name = "Baked Sourdough Bread", SellIn = 3, Quality = 5}
    };

    private static readonly IList<Item> DefaultItems = CreateItems();
    private static readonly IList<Item> NewItems = CreateItems();
    
    private readonly GildedRoseKata.GildedRose _gildedRose = new(NewItems);
    
    [Fact]
    public void ShouldNotModifyCannedBeans()
    {
        var oldBeans = DefaultItems.Where(i => i.Name == "Canned Beans");
        
        _gildedRose.UpdateQuality();

        var newBeans = NewItems.Where(i => i.Name == "Canned Beans");
        
        
        Assert.All(newBeans, bean =>
        {
           Assert.Equal(80, bean.Quality); 
           Assert.Contains(oldBeans, o => o.SellIn == bean.SellIn);
        });
    }
}