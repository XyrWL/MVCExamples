using System;
using System.Collections.Generic;
using System.Linq;
using KioskProject.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KioskProjectTests
{
    [TestClass]
    public class TestClass
    {
        const int NUMBER_OF_RATINGS_TO_USE = 10;

        [TestMethod]
        public void TestMethod_AverageForOneReview()
        {
            var rater = new KioskRater(BuildKiosk(8));
            var actual = rater.ComputeOverallRate(NUMBER_OF_RATINGS_TO_USE).Rating;
            var expected = 8;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod_AverageForTwoReviews()
        {
            var rater = new KioskRater(BuildKiosk(4, 6));
            var actual = rater.ComputeOverallRate(NUMBER_OF_RATINGS_TO_USE).Rating;
            var expected = 5;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod_ComputedTwoRatings()
        {
            var rater = new KioskRater(BuildKiosk(3, 9));
            var actual = rater.ComputeWeightedRate(NUMBER_OF_RATINGS_TO_USE).Rating;
            var expected = 5;
            Assert.AreEqual(actual, expected);
        }

        private Kiosk BuildKiosk(params int[] ratings) 
            => new Kiosk {Reviews = ratings.Select(r => new Review {Rating = r}).ToList()};
    }
}
