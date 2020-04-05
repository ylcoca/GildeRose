using Services;
using System;
using System.Configuration;

namespace DAL.Entity
{
    public class BackstagePasses : ItemObjects
    {
        const int doubleTheDefaultValue = 2;
        const int tenDays = 10;
        const int sixDays = 6;
        const int zeroDays = 0;

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

                if (SellIn <= tenDays && SellIn >= sixDays)
                {
                    Quality++;
                }
                else if (SellIn < sixDays)
                {
                    this.Quality += doubleTheDefaultValue;
                }
                else if (SellIn < zeroDays)
                {
                    Quality -= Quality;
                }
            }
                
        }
    }
}
