using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TDD.Tests.Features;

namespace TDD.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var data = new CoffeeShop();
            data.Reviews = new List<ShopReviews>();
            data.Reviews.Add(new ShopReviews()
            {
                ratings = 4
            });

            var rateIndicator = new ShopRater(data);
            var result = rateIndicator.ComputeRating(10);

            Assert.AreEqual(4, result.Rating);
        }
    }
}
