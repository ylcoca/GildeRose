
namespace DAL.Entity
{
    public class Conjured : ItemObjects
    {
        const int decreasedQualityByTwo = 2;

        public Conjured(Item item)
        {
            this.Name = item.Name;
            this.SellIn = item.SellIn;
            this.Quality = item.Quality;
        }
        public override void UpdateQuality()
        {
            if (Quality > 0)
            {
                Quality -= decreasedQualityByTwo;
            }          
        }
    }

}
