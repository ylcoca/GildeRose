using Services;
using System;
using System.Configuration;

namespace DAL.Entity
{
    public class BackstagePasses : ItemObjects
    {
        

        public BackstagePasses(Item item)
        {
            this.Name = item.Name;
            this.SellIn = item.SellIn;
            this.Quality = item.Quality;
        } 

        public override void UpdateQuality()
        {
            if (this.Quality < this.highestQualityValue)
            {
                this.Quality ++;
                if (SellIn < 11 && SellIn >= 6)
                {
                    Quality++;
                }
                else if (SellIn < 6)
                {
                    this.Quality += 2;
                }                
            }

            UpdateSellIn();
                
        }

        public override void UpdateSellIn()
        {
            this.SellIn--;
            if (SellIn < 0)
            {
                Quality -= Quality;
            }
        }
    }
}
