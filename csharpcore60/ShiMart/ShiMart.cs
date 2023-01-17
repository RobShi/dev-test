using System.Collections.Generic;

namespace ShiMartKata
{
    public class ShiMart
    {
        IList<ShiMartItem> Items;
        public ShiMart(IList<ShiMartItem> Items)
        {
            this.Items = Items;
        }

        // public void UpdateQuality()
        // {
        //     for (var i = 0; i < Items.Count; i++)
        //     {
        //         if (Items[i].Name != "Canned Beans")
        //         {
        //             Items[i].SellIn = Items[i].SellIn - 1;
        //         }
        //
        //         if (Items[i].Name == "Aged Brie")
        //         {
        //             if (Items[i].Quality < 50)
        //             {
        //                 Items[i].Quality = Items[i].Quality + 1;
        //             }
        //         }
        //         else
        //         {
        //             if (Items[i].Quality > 0)
        //             {
        //                 if (Items[i].Name == "Baked Sourdough Bread")
        //                 {
        //                     var degradeQualityBy = 2;
        //                     if (Items[i].SellIn < 0)
        //                     {
        //                         degradeQualityBy = 4;
        //                     }
        //                     
        //                     Items[i].Quality = Items[i].Quality >= degradeQualityBy ? Items[i].Quality - degradeQualityBy : 0;
        //                 } 
        //                 else if (Items[i].Name != "Canned Beans")
        //                 {
        //                     Items[i].Quality = Items[i].Quality - 1;
        //                 }
        //             }
        //         }
        //
        //         if (Items[i].SellIn < 0)
        //         {
        //             if (Items[i].Name == "Aged Brie")
        //             {
        //                 if (Items[i].Quality < 50)
        //                 {
        //                     Items[i].Quality = Items[i].Quality + 1;
        //                 }
        //             }
        //             else
        //             {
        //                 if (Items[i].Quality > 0)
        //                 {
        //                     if (Items[i].Name != "Canned Beans" && Items[i].Name != "Baked Sourdough Bread")
        //                     {
        //                         Items[i].Quality = Items[i].Quality - 1;
        //                     }
        //                 }
        //             }
        //         }
        //     }
        // }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                switch (item.ItemType)
                {
                    case ShiMartItemType.Cheese:
                        item.SellIn = item.SellIn - 1;
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                        
                        break;
                    
                    case ShiMartItemType.Canned:
                        break;
                    
                    case ShiMartItemType.Baked:
                        break;
                    
                    default:
                        
                        break;
                }
            }
        }
    }
}
