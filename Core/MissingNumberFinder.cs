using System.Collections.Generic;

namespace Core
{
    public static class MissingNumberFinder
    {
        /// <summary>
        ///     Finds the single missing number in a consecutive sequence that is not in order.
        /// </summary>
        /// <param name="numbers">Consecutive sequence of numbers with one missing. Not in order.</param>
        /// <returns>The missing number.</returns>
        public static int Find(IEnumerable<int> numbers)
        {
            var min = int.MaxValue;
            var max = int.MinValue;
            var actualSum = 0;
            foreach (var number in numbers)
            {
                if (min > number) min = number;
                if (max < number) max = number;
                actualSum += number;
            }

            return (int)((max - min + 1) / 2d * (min + max)) - actualSum;
        }
    }
}