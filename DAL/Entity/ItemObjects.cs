using Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public abstract class ItemObjects : Item, IGildedRoseService
    {
        public int highestQualityValue = int.Parse(ConfigurationManager.AppSettings["highestQualityValue"]);

        public void Update()
        {
            UpdateQuality();
            DecreaseSellIn();

            if (SellIn < 0)
            {
                UpdateQuality();
            }
        }

        public virtual void UpdateQuality()
        {
            if (Quality < highestQualityValue)
            {
                Quality++;
            }
        }

        public virtual void DecreaseSellIn()
        {
            SellIn--;
        }

       
    }
}
