using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class BetterWithAgeUpdateableItem : UpdateableItem
    {
        public override void UpdateQualityItem()
        {
            
            SellIn--;
            if (this.Quality >= 50) return;
            if (this.SellIn < 0)
            {
                this.Quality++;
            }
            this.Quality++;
        }
    }
}
