namespace Core;

public static class ModeCharacterFinder
{
    /// <summary>
    ///     Returns the character with most occurrences in the text.
    ///     Casing is ignored and lowercase is returned.
    ///     If there are multiple characters with the equal highest occurrence,
    ///     the one that appeared first in the text is returned.
    ///     https://en.wikipedia.org/wiki/Mode_(statistics)
    /// </summary>
    public static char Find(string text)
    {
        var charCounts = new Dictionary<char, int>();

        foreach (var c in text)
        {
            // Bug #1: the "charCounts.TryGetValue(c)" call is case sensitive.
            if (charCounts.TryGetValue(c, out var value))
            {
                charCounts[c] = ++value;
            }
            else
            {
                charCounts.Add(c, 1);
            }
        }

        // Bug #2: dictionary does not guarantee the order, when accessing its elements.
        //         The "MaxBy" call cannot guarantee that the first character
        //         with the highest count is sorted to the first.
        var highestChar = charCounts.MaxBy(pair => pair.Value);
        return highestChar.Key;

        // Improvement: instead of using a dictionary, use a list with a custom name:value data structure.
    }
}