using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        private const int Days = 31;

        public static void Main(string[] args)
        {
            var Items = new List<UpdateableItem>
            {

                FoodItemFactory.Create(Foods.GenericItem, "Bananas", 10, 20),
                FoodItemFactory.Create(Foods.AgedBrie, "Aged Brie", 2, 0),

                FoodItemFactory.Create(Foods.GenericItem, "Eggs", 5, 7),
                FoodItemFactory.Create(Foods.GenericItem, "Eggs", 12, 5),

                FoodItemFactory.Create(Foods.CannedBeans, "Canned Beans", 0, 80),
                FoodItemFactory.Create(Foods.CannedBeans, "Canned Beans", -1, 80),

                FoodItemFactory.Create(Foods.DoubleDegradeItem, "Baked Sourdough Bread", 3, 6)
            };

            var app = new GildedRose(Items);


            for (var i = 0; i < (Days + 1); i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }

            Console.ReadKey();
        }
    }
}
