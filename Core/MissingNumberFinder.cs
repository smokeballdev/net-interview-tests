namespace Core;

public static class MissingNumberFinder
{
    /// <summary>
    ///     Finds the single missing number in a consecutive sequence that is not in order.
    /// </summary>
    /// <param name="numbers">Consecutive sequence of numbers with one missing. Not in order.</param>
    /// <returns>The missing number.</returns>
    public static int Find(IEnumerable<int> numbers)
    {
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