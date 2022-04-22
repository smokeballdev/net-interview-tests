using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public static class ModeCharacterFinder
    {
        /// <summary>
        ///     Returns the character with most occurrences in the text.
        ///     Case is ignored and lowercase is returned.
        ///     If there are multiple characters with equal highest occurrence,
        ///     the one that appeared first in the text is returned.
        ///     https://en.wikipedia.org/wiki/Mode_(statistics)
        /// </summary>
        public static char Find(string text)
        {
            var charCounts = new Dictionary<char, int>();

            foreach (var c in text)
            {
                // Bug #1: the "charCounts.ContainsKey(c)" check is case sensitive.
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts.Add(c, 1);
                }
            }

            // Bug #2: dictionary does not guarantee the order when accessing its elements,
            //         the "OrderByDescending" call can not guarantee that the first character
            //         with the highest count is sorted to the first.
            var highestChar = charCounts.OrderByDescending(pair => pair.Value).First();
            return highestChar.Key;

            // Improvement: instead of using a dictionary, use a list with a custom name:value data structure.
        }
    }
}