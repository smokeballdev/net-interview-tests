using Core;
using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class WhenFindingMissingNumber
    {
        [TestCase(1, 10, 3, 1)]
        [TestCase(5, 25, 17, 2)]
        [TestCase(104, 266, 105, 3)]
        public void ShouldFindMissingNumber(int smallest, int largest, int missing, int seed)
        {
            var random = new Random(seed);
            var numbers = Enumerable
                .Range(smallest, largest - smallest + 1)
                .Where(i => i != missing)
                .OrderBy(_ => random.Next());

            Assert.AreEqual(missing, MissingNumberFinder.Find(numbers));
        }
    }
}
