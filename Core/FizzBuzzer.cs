using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public static class FizzBuzzer
    {
        /// <summary>
        ///     Returns sequence of numbers with
        ///     multiples of 3 replaced by "Fizz"
        ///     multiples of 5 replaced by "Buzz"
        ///     multiples of both replaced by "FizzBuzz".
        /// </summary>
        /// <param name="start">Inclusive start point.</param>
        /// <param name="end">Inclusive end point.</param>
        /// <returns>FizzBuzz sequence.</returns>
        public static IEnumerable<string> Generate(int start, int end)
        {
            return Enumerable.Range(start, end - start + 1).Select(i =>
                i % 15 == 0 ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : i.ToString());
        }
    }
}