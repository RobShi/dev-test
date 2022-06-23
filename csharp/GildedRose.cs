using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        private void NoOp(Item item)
        {
        }
        
        private void DecrementSellIn(Item item)
        {
            item.SellIn -= 1;
        }
        
        private void DecrementQuality(Item item)
        {
            item.Quality -= 1;
        }
        
        private void DecrementQualityDouble(Item item)
        {
            item.Quality -= 2;
        }

        private void IncrementQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }

        private Action<Item> _getSellIn(Item item)
        {
            if (item.Name == "Canned Beans")
            {
                return NoOp;
            }

            return DecrementSellIn;
        }

        private Action<Item> _getQuality(Item item)
        {
            if (item.Name == "Aged Brie")
            {
                return IncrementQuality;
            }

            if (item.Name == "Canned Beans")
            {
                return NoOp;
            }

            return DecrementQuality;
        }
        
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                _getSellIn(Items[i]).Invoke(Items[i]);
                //_getQuality(Items[i]).Invoke(Items[i]);
                
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
                        if (Items[i].Name != "Canned Beans")
                        {
                            if (Items[i].Name.ToLower().StartsWith("baked") && Items[i].Quality > 1)
                            {
                                Items[i].Quality = Items[i].Quality - 2;
                            }
                            else
                            {
                                Items[i].Quality = Items[i].Quality - 1;
                            }
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
                            if (Items[i].Name != "Canned Beans")
                            {
                                if (Items[i].Name.ToLower().StartsWith("baked") && Items[i].Quality > 1)
                                {
                                    Items[i].Quality = Items[i].Quality - 2;
                                }
                                else
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
