
using BuisnessLogic;
using DAL.Entity;
using NUnit.Framework;
using System.Collections.Generic;

namespace Test
{
    [TestFixture]
    public class GildedRoseTest
    {

        [SetUp]
        public void TestInit()
        {
            // Runs before each test. (Optional)
            
        }

        [Test]
        public void NameAgedBrie()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
            var result = new GildedRoseBusinessLogic(item).items;
            Assert.AreEqual("Aged Brie", result[0].Name);
        }

        [Test]
        public void HasSellInAgedBrie()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 0 } };
            var result = new GildedRoseBusinessLogic(item).items;
            Assert.AreEqual(10, result[0].SellIn);
        }

        [Test]
        public void HasQualityAgedBrie()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 } };
            var result = new GildedRoseBusinessLogic(item).items;
            Assert.AreEqual(10, result[0].Quality);
        }

        [Test]
        public void BrieImprovesWithAge()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
            var items = new GildedRoseBusinessLogic(item).items[0];
            items.UpdateQuality();
            Assert.AreEqual(2, items.Quality);
        }

        [Test]
        public void AfterSellByDateIncreaseInOneAgedBrie()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            var items = new GildedRoseBusinessLogic(item).items[0];
            items.UpdateQuality();
            Assert.AreEqual(1, items.Quality);
        }

        [Test]
        public void AfterSellByDateDecreaseInOneAgedBrie()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            var items = new GildedRoseBusinessLogic(item).items[0];
            items.UpdateQuality();
            Assert.AreEqual(1, items.Quality);
        }

        [Test]
        public void AfterSellByDateStillTheSameSulfuras()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 } };
            var items = new GildedRoseBusinessLogic(item).items[0];
            items.UpdateQuality();
            Assert.AreEqual(80, items.Quality);
        }

        [Test]
        public void AfterSellByDateDecresesInDoubleConjure()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            var items = new GildedRoseBusinessLogic(item).items[0];
            items.UpdateQuality();
            Assert.AreEqual(4, items.Quality);
        }

        [Test]
        public void BackStageIncreasesValueByDate()
        {
            IList<Item> item = new List<Item> { new Item {
                           Name = "Backstage passes to a TAFKAL80ETC concert",
                           SellIn = 15,
                           Quality = 20
                       } };
            var items = new GildedRoseBusinessLogic(item).items[0];
            items.UpdateQuality();
            Assert.AreEqual(21, items.Quality);
        }

        [Test]
        public void BackStageLossesAllValueInConcertDay()
        {
            IList<Item> item = new List<Item> { new Item {
                           Name = "Backstage passes to a TAFKAL80ETC concert",
                           SellIn = 0,
                           Quality = 50
                       } };
            var items = new GildedRoseBusinessLogic(item).items[0];
            items.UpdateQuality();
            Assert.AreEqual(0, items.Quality);
        }

        [Test]
        public void QualityOfItemLimit50()
        {
            IList<Item> item = new List<Item> { new Item {
                           Name = "Backstage passes to a TAFKAL80ETC concert",
                           SellIn = 1,
                           Quality = 50
                       } };
            var items = new GildedRoseBusinessLogic(item).items[0];
            items.UpdateQuality();
            Assert.AreEqual(50, items.Quality);
        }

        [Test]
        public void BackstageValue10DaysBefore()
        {
            IList<Item> item = new List<Item> { new Item {
                           Name = "Backstage passes to a TAFKAL80ETC concert",
                           SellIn = 8,
                           Quality = 47
                       } };
            var items = new GildedRoseBusinessLogic(item).items[0];
            items.UpdateQuality();
            Assert.AreEqual(49, items.Quality);
        }

        [Test]
        public void BackstageValueTwoDaysBefore()
        {
            IList<Item> item = new List<Item> { new Item {
                           Name = "Backstage passes to a TAFKAL80ETC concert",
                           SellIn = 2,
                           Quality = 40
                       } };
            var items = new GildedRoseBusinessLogic(item).items[0];
            items.UpdateQuality();
            Assert.AreEqual(43, items.Quality);
        }
    }
}
