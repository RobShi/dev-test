using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class FoodItemFactory
    {

        public static UpdateableItem Create(Foods foodType, string itemName, int sellin,  int quality)
        {
            UpdateableItem item;
            if (foodType == Foods.AgedBrie)
            {
                item = new BetterWithAgeUpdateableItem();
            }
            else if (foodType == Foods.CannedBeans)
            {
                item = new CannedUpdatedableItem();
                
            }
            else if (foodType == Foods.DoubleDegradeItem)
            {
                item = new DoubleDegradeItem();
            }
            else
            {
                item = new BetterWithAgeUpdateableItem();
            }

            item.Name = itemName;
            item.Quality = quality;
            item.SellIn = sellin;
            return item;

        }
    }
}
