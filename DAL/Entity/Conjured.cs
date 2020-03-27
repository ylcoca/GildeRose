using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Conjured : ItemObjects
    {

        public Conjured(string Name, int SellIn, int Quality)
        {
            this.Name = Name;
            this.SellIn = SellIn;
            this.Quality = Quality;
        }
        public override void UpdateQuality()
        {
            if (this.Quality > 0)
            {
                this.Quality -= 2;
            }

            UpdateSellIn();

          
        }
        public override void UpdateSellIn()
        {
            this.SellIn--;
            if (SellIn < 0 && Quality > 0)
            {
                this.Quality -= 2;
                
            }
        }
    }

}
