using Core;
using NUnit.Framework;

namespace Tests;

public class WhenIdentifyingPalindromes
{
    [TestCase("hannah")]
    [TestCase("kayak")]
    [TestCase("racecar")]
    [TestCase("12321")]
    public void ShouldIdentifyPalindromes(string palindrome)
    {
        Assert.That(PalindromeIdentifier.IsPalindrome(palindrome), Is.True);
    }

    [TestCase("potato")]
    [TestCase("rice")]
    [TestCase("1234")]
    public void ShouldNotIdentifyNonPalindromes(string nonPalindrome)
    {
        Assert.That(PalindromeIdentifier.IsPalindrome(nonPalindrome), Is.False);
    }
}