using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
   public class ElixirOfTheMongoose : ItemObjects
    {
        public ElixirOfTheMongoose(Item item)
        {
            this.Name = item.Name;
            this.SellIn = item.SellIn;
            this.Quality = item.Quality;
        }

        public override void UpdateQuality()
        {
            if (this.Quality > 0)
            {
                this.Quality--;
            }
            UpdateSellIn();
            
        }

        public override void UpdateSellIn()
        {
            this.SellIn--;
            if (SellIn < 0 && Quality > 0)
            {
                Quality--;
            }
        
        }
    }
}
