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
            // Note, it is acceptable to use a Dictionary<char, int> here,
            // but dictionary does not guarantee the order when looping it
            // in a for loop.
            var charCounts = new List<CharacterCount>();
            foreach (var c in text.ToLower())
            {
                var charCount = charCounts.Find(x => x.Character == c);
                if (charCount == null)
                {
                    charCounts.Add(new CharacterCount(c, 1));
                }
                else
                {
                    charCount.Count++;
                }
            }

            var highCharCount = charCounts[0];
            foreach (var charCount in charCounts.Skip(1))
            {
                if (charCount.Count > highCharCount.Count)
                {
                    highCharCount = charCount;
                }
            }

            return highCharCount.Character;
        }

        private class CharacterCount
        {
            internal readonly char Character;
            internal int Count;

            public CharacterCount(char character, int count)
            {
                Character = character;
                Count = count;
            }
        }
    }
}