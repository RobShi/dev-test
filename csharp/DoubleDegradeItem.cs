using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class DoubleDegradeItem : UpdateableItem
    {
        public override void UpdateQualityItem()
        {
            this.SellIn--;

            if (Quality > 0)
            {
                if (SellIn < 0)
                {
                    Quality -= 4;
                }
                else
                {
                    Quality -= 2;
                }
            }
        }
    }
}
