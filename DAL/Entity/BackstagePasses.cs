using Services;
using System;
using System.Configuration;

namespace DAL.Entity
{
    public class BackstagePasses : ItemObjects
    {
        int highestQualityValue = int.Parse(ConfigurationManager.AppSettings["highestQualityValue"]);

        public BackstagePasses(string Name, int SellIn, int Quality)
        {
            this.Name = Name;
            this.SellIn = SellIn;
            this.Quality = Quality;
        }

        public override void UpdateQuality()
        {
            if (this.Quality < highestQualityValue)
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
