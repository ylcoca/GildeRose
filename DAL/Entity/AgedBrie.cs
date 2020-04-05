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
    }
}
