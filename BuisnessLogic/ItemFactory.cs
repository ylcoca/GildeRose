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

            foreach (var item in Items)
            {

                itemObjects.Add(ItemObjects(item));

            }

            return itemObjects;
        }

        public static ItemObjects ItemObjects(Item item)
        {
            ItemObjects inheritedItem = null;
            switch (item.Name)
            {
                case "+5 Dexterity Vest":
                    inheritedItem = new DexterityVest(item);
                    break;
                case "Aged Brie":
                    inheritedItem = new AgedBrie(item);
                    break;
                case "Elixir of the Mongoose":
                    inheritedItem = new ElixirOfTheMongoose(item);
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    inheritedItem = new Sulfuras(item);
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    inheritedItem = new BackstagePasses(item);
                    break;
                case "Conjured Mana Cake":
                    inheritedItem = new Conjured(item);
                    break;
            }
            return inheritedItem;
        }
    }
}