namespace Core
{
    public static class PalindromeIdentifier
    {
        /// <summary>
        ///     Identifies if the text is a palindrome (the same forwards as backwards).
        ///     https://en.wikipedia.org/wiki/Palindrome
        /// </summary>
        /// <param name="text">Text to be checked.</param>
        /// <returns>True if a palindrome.</returns>
        public static bool IsPalindrome(string text)
        {
            var hasCharacterDifferent = false;
            for (var startIndex = 0; startIndex < text.Length; startIndex++)
            {
                var endIndex = text.Length - 1 - startIndex;

                // Bug: "hasCharacterDifferent" will be set to true as long as the last character and the first character are the same.
                // Improvement #1: the first time when "text[startIndex] != text[endIndex]", we can return false already.
                // Improvement #2: when "startIndex >= endIndex", we can return true already.
                hasCharacterDifferent = text[startIndex] != text[endIndex];
            }

            if (hasCharacterDifferent)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}