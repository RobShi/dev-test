using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class GenericUpdatableItem : UpdateableItem
    {
        public override void UpdateQualityItem()
        {
           
            SellIn--;
            if (SellIn < 0 && this.Quality > 0)
            {
                this.Quality--;
            }
        }
    }
}
