namespace Core;

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
        // Bug #1: not using "else if" makes number 15 to add "Fizz", "Buzz" and "FizzBuzz" to the result.
        // Bug #2: missing result.Add(i.ToString()) when i can't mod 3, 5 and 15 to 0.
        // Bug #3: for loop doesn't check the end number.
        // Improvement #1: first if check mods 3 and 5 already, it doesn't have to be repeated in the 3rd if check when we are using "else if".
        // Improvement #2: code can be shortened to a single "Enumerable.Range" call using the "?:" conditional operator.
        // Improvement #3: can use "yield return" instead of using a result list.
        var result = new List<string>();
        for (var i = start; i < end; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result.Add("FizzBuzz");
            }

            if (i % 3 == 0)
            {
                result.Add("Fizz");
            }

            if (i % 5 == 0)
            {
                result.Add("Buzz");
            }
        }

        return result;
    }
}