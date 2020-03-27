using Services;
using System.Configuration;

namespace DAL.Entity
{
    public class AgedBrie : ItemObjects
    {
        int highestQualityValue = int.Parse(ConfigurationManager.AppSettings["highestQualityValue"]);
        public AgedBrie(string Name, int SellIn, int Quality)
        {
            this.Name = Name;
            this.SellIn = SellIn;
            this.Quality = Quality;
        }
        public override void UpdateQuality()
        {   
            if (Quality < highestQualityValue)
            {
                Quality++;
            }

            UpdateSellIn();               
        }

        public override void UpdateSellIn()
        {
            SellIn--;
            if (SellIn < 0 && Quality < highestQualityValue)
            {
                Quality++;
            }
        }
    }
}
