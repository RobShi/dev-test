using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        private void CalculateNewQuality(Item item)
        {
            if (item.Name == "Canned Beans") return;
            
            item.SellIn -= 1;

            int qualityChange = 1;

            if (item.Name == "Aged Brie")
            {
                qualityChange = -1;
            }

            if (item.Name.StartsWith("Baked"))
            {
                qualityChange = 2;
            }

            if (item.SellIn < 0)
            {
                qualityChange *= 2;
            }

            item.Quality = Math.Clamp(item.Quality - qualityChange, 0, 50);
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                CalculateNewQuality(item);
            }
        }
    }
}
