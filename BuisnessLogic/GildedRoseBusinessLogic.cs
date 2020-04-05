using DAL.Entity;
using System;
using System.Collections.Generic;


namespace BuisnessLogic
{
    public class GildedRoseBusinessLogic
    {
        public IList<ItemObjects> items;
        public const int days = 31;

        public GildedRoseBusinessLogic(IList<Item> items)
        {

            this.items = ItemFactory.BuildClass(items);
        }

        public void PrintResult()
        {
            for (var day = 0; day < days; day++)
            {
                Console.WriteLine("-------- day " + day + " --------");
                Console.WriteLine("name, sellIn, quality");

                foreach (var item in this.items)
                {
                    Console.WriteLine(item);
                    item.UpdateQuality();
                }
                Console.WriteLine("");
            }
        }



    }
}
