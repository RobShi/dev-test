﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class CannedUpdatedableItem : UpdateableItem
    {
        public override void UpdateQualityItem()
        {
            this.Quality = 80;
            return;
        }
    }
}
