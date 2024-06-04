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
        var result = new List<string>();
        for (var i = start; i < end; i++)
        {
            switch (i % 3)
            {
                case 0 when i % 5 == 0:
                    result.Add("FizzBuzz");
                    break;
                case 0:
                    result.Add("Fizz");
                    break;
                default:
                {
                    if (i % 5 == 0)
                    {
                        result.Add("Buzz");
                    }

                    break;
                }
            }
        }

        return result;
    }
}