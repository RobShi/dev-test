
using System.Collections.Generic;

namespace ShiMartKata
{
    public class ShiMart
    {
        IList<Item> Items;
        public ShiMart(IList<Item> Items)
        {
            this.Items = Items;
        }

        // TODO:Increase code readbility
        // 1. Reduce if conditions
        // 2. Refacor code in more methods
        // 3. Refactor SellIn logic in a new method : UpdateSellIn. Note: QualityCalulation is dependent on SellIn Value


        // Make the program item independent 
        // 1. Item.cs in a class ItemWithType.cs, inherits Item.cs
        // 2. Use Builder pattern for BuildingItem
        // 3. It requires creation of centeraliztion of multiple type of items and handle related busisness logic,
        // I would prefer, use Abstarct Factory Pattern for different type of items        
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Canned Beans")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].Name == "Aged Brie")
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                }
                else
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Canned Beans" && !Items[i].Name.Contains("Baked"))
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }

                        if (Items[i].Name.Contains("Baked"))
                        {
                            Items[i].Quality = Items[i].Quality - 2;
                        }
                    }
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name == "Aged Brie")
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality > 0)
                        {
                            if (Items[i].Name != "Canned Beans" && !Items[i].Name.Contains("Baked"))
                            {
                                Items[i].Quality = Items[i].Quality - 1;
                            }
                            if (Items[i].Name.Contains("Baked"))
                            {
                                Items[i].Quality = Items[i].Quality - 2;
                            }
                        }
                    }
                }
            }
        }
    }
}
