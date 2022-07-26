using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<UpdateableItem> Items;
        public GildedRose(IList<UpdateableItem> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (UpdateableItem item in Items)
            {
                item.UpdateQualityItem();
            }
        }
    }
}
