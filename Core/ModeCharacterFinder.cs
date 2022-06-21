using System.Collections.Generic;

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
            text = text.ToLower();
            var textLength = text.Length;
            var characterMap = new Dictionary<char, (int Index, int Count)>();
            for (var i = 0; i < textLength; i++)
            {
                characterMap[text[i]] = characterMap.TryGetValue(text[i], out var stat)
                    ? (stat.Index, stat.Count + 1)
                    : (i, 1);
            }

            var maxCount = 0;
            var minIndex = textLength;
            char maxCountMinIndexCharacter = default;
            foreach (var pair in characterMap)
            {
                var (index, count) = pair.Value;
                if (count > maxCount)
                {
                    minIndex = index;
                    maxCount = count;
                    maxCountMinIndexCharacter = pair.Key;
                }
                else if (count == maxCount && index < minIndex)
                {
                    minIndex = index;
                    maxCountMinIndexCharacter = pair.Key;
                }
            }

            return maxCountMinIndexCharacter;
        }
    }
}