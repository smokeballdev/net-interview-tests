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
            var length = text.Length;
            var endIndex = length - 1;
            for (var i = 0; i < length; i++)
            {
                var j = endIndex - i;
                if (i >= j)
                {
                    break;
                }

                if (text[i] != text[j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}