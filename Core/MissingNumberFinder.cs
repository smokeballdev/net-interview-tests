using System;
using System.Collections.Generic;
using System.Linq;

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
            // Bug: the loop assumes the numbers are already ordered from small to large.
            // Improvement #1: When for loop checks "i < numberList.Count" it access the "numberList.Count" every time.
            //                 The count can be stored in a variable if the number list is huge.
            // Improvement #2: Ordering the number list can be very expensive if it is huge.
            //                 See sample answer for solution without ordering the list.
            var numberList = numbers.ToList();
            for (var i = 0; i < numberList.Count; i++)
            {
                var currentNumber = numberList[i];
                var nextNumber = numberList[i + 1];
                var expectedNextNumber = currentNumber + 1;
                if (expectedNextNumber != nextNumber)
                {
                    return expectedNextNumber;
                }
            }

            throw new Exception("Missing number not found");
        }
    }
}