using Core;
using NUnit.Framework;

namespace Tests
{
    public class WhenBuyingBottles
    {
        [TestCase(2, 10, 15)]
        public void ShouldCalculateMaximumNumberOfBottles(int waterUnitPrice, int totalAmountInDollars,
            int expectedMaximumBottles)
        {
            Assert.AreEqual(expectedMaximumBottles,
                BottleCalculator.GetMaximumNumberOfBottles(waterUnitPrice, totalAmountInDollars));
        }
    }
}