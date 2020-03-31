using Services;
using System.Configuration;

namespace DAL.Entity
{
    public class AgedBrie : ItemObjects
    {
        public AgedBrie(Item item)
        {
            this.Name = item.Name;
            this.SellIn = item.SellIn;
            this.Quality = item.Quality;
        }
        public override void UpdateQuality()
        {
            if (Quality < this.highestQualityValue)
            {
                Quality++;
            }

            UpdateSellIn();
        }

        public override void UpdateSellIn()
        {
            SellIn--;
            if (SellIn < 0 && Quality < this.highestQualityValue)
            {
                Quality++;
            }
        }
    }
}
