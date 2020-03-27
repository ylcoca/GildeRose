using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Sulfuras : ItemObjects
    {
        public Sulfuras(string Name, int SellIn, int Quality)
        {
            this.Name = Name;
            this.SellIn = SellIn;
            this.Quality = Quality;
        }

        public override void UpdateQuality()
        {
            this.Quality = 80;
        }

        public override void UpdateSellIn() { }
    }
}
