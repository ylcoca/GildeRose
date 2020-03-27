
using BuisnessLogic;
using DAL.Entity;
using NUnit.Framework;
using System.Collections.Generic;

namespace Test
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void NameAgedBrie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
            var result = new GildedRoseBusinessLogic(Items).Items;
            Assert.AreEqual("Aged Brie", result[0].Name);
        }

        [Test]
        public void HasSellInAgedBrie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 0 } };
            var result = new GildedRoseBusinessLogic(Items).Items;
            Assert.AreEqual(10, result[0].SellIn);
        }

        [Test]
        public void HasQualityAgedBrie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 } };
            var result = new GildedRoseBusinessLogic(Items).Items;
            Assert.AreEqual(10, result[0].Quality);
        }

        [Test]
        public void BrieImprovesWithAge()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
            var item = new GildedRoseBusinessLogic(Items).Items[0];
            item.UpdateQuality();
            Assert.AreEqual(2, item.Quality);
        }

        [Test]
        public void AfterSellByDateIncreaseInOneAgedBrie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            var item = new GildedRoseBusinessLogic(Items).Items[0];
            item.UpdateQuality();
            Assert.AreEqual(1, item.Quality);
        }

        [Test]
        public void AfterSellByDateDecreaseInOneAgedBrie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            var item = new GildedRoseBusinessLogic(Items).Items[0];
            item.UpdateQuality();
            Assert.AreEqual(1, item.Quality);
        }

        [Test]
        public void AfterSellByDateStillTheSameSulfuras()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 } };
            var item = new GildedRoseBusinessLogic(Items).Items[0];
            item.UpdateQuality();
            Assert.AreEqual(80, item.Quality);
        }

        [Test]
        public void AfterSellByDateDecresesInDoubleConjure()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            var item = new GildedRoseBusinessLogic(Items).Items[0];
            item.UpdateQuality();
            Assert.AreEqual(4, item.Quality);
        }

        [Test]
        public void BackStageIncreasesValueByDate()
        {
            IList<Item> Items = new List<Item> { new Item {
                           Name = "Backstage passes to a TAFKAL80ETC concert",
                           SellIn = 15,
                           Quality = 20
                       } };
            var item = new GildedRoseBusinessLogic(Items).Items[0];
            item.UpdateQuality();
            Assert.AreEqual(21, item.Quality);
        }

        [Test]
        public void BackStageLossesAllValueInConcertDay()
        {
            IList<Item> Items = new List<Item> { new Item {
                           Name = "Backstage passes to a TAFKAL80ETC concert",
                           SellIn = 0,
                           Quality = 50
                       } };
            var item = new GildedRoseBusinessLogic(Items).Items[0];
            item.UpdateQuality();
            Assert.AreEqual(0, item.Quality);
        }

        [Test]
        public void QualityOfItemLimit50()
        {
            IList<Item> Items = new List<Item> { new Item {
                           Name = "Backstage passes to a TAFKAL80ETC concert",
                           SellIn = 1,
                           Quality = 50
                       } };
            var item = new GildedRoseBusinessLogic(Items).Items[0];
            item.UpdateQuality();
            Assert.AreEqual(50, item.Quality);
        }

        [Test]
        public void BackstageValue10DaysBefore()
        {
            IList<Item> Items = new List<Item> { new Item {
                           Name = "Backstage passes to a TAFKAL80ETC concert",
                           SellIn = 8,
                           Quality = 47
                       } };
            var item = new GildedRoseBusinessLogic(Items).Items[0];
            item.UpdateQuality();
            Assert.AreEqual(49, item.Quality);
        }

        [Test]
        public void BackstageValueTwoDaysBefore()
        {
            IList<Item> Items = new List<Item> { new Item {
                           Name = "Backstage passes to a TAFKAL80ETC concert",
                           SellIn = 2,
                           Quality = 40
                       } };
            var item = new GildedRoseBusinessLogic(Items).Items[0];
            item.UpdateQuality();
            Assert.AreEqual(43, item.Quality);
        }
    }
}
