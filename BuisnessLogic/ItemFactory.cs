using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public static class ItemFactory
    {
        public static List<ItemObjects> BuildClass(IList<Item> Items)
        {
            List<ItemObjects> itemObjects = new List<ItemObjects>();
            ItemObjects inheritedItem = null;
            foreach (var item in Items)
            {
                switch (item.Name)
                {
                    case "+5 Dexterity Vest":
                        inheritedItem = new DexterityVest(item);
                        break;
                    case "Aged Brie":
                        inheritedItem = new AgedBrie(item.Name, item.SellIn, item.Quality);
                        break;
                    case "Elixir of the Mongoose":
                        inheritedItem = new ElixirOfTheMongoose(item.Name, item.SellIn, item.Quality);
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        inheritedItem = new Sulfuras(item.Name, item.SellIn, item.Quality);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        inheritedItem = new BackstagePasses(item.Name, item.SellIn, item.Quality);
                        break;
                    case "Conjured Mana Cake":
                        inheritedItem = new Conjured(item.Name, item.SellIn, item.Quality);
                        break;
                }


                itemObjects.Add(inheritedItem);

            }

            return itemObjects;
        }
    }
}
