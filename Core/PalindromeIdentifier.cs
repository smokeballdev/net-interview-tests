namespace Core;

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

            hasCharacterDifferent = text[startIndex] != text[endIndex];
        }

        return !hasCharacterDifferent;
    }
}