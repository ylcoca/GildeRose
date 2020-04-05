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
        const int fixedQualitySulfuras = 80;
        public Sulfuras(Item item)
        {
            this.Name = item.Name;
            this.SellIn = item.SellIn;
            this.Quality = fixedQualitySulfuras;
        }
    }
}
