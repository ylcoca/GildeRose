using DAL.Entity;
using System;
using System.Collections.Generic;


namespace BuisnessLogic
{
    public class GildedRoseBusinessLogic
    {
        public IList<ItemObjects> Items;
        public const int Days = 31;

        public GildedRoseBusinessLogic(IList<Item> Items)
        {

            this.Items = ItemFactory.BuildClass(Items);
        }

        public void printResult()
        {
            for (var day = 0; day < Days; day++)
            {
                Console.WriteLine("-------- day " + day + " --------");
                Console.WriteLine("name, sellIn, quality");

                foreach (var item in this.Items)
                {
                    Console.WriteLine(item);
                   item.UpdateQuality();
                }
                Console.WriteLine("");
            }
        }

        

    }
}
