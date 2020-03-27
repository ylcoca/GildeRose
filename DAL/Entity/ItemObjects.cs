using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public abstract class ItemObjects : Item, IGildedRoseService
    {
        public abstract void UpdateQuality();

        public abstract void  UpdateSellIn();
    }
}
