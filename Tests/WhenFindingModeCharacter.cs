using Core;
using NUnit.Framework;

namespace Tests;

public class WhenFindingModeCharacter
{
    [TestCase("Aab", 'a')]
    [TestCase("Baabb", 'b')]
    public void ShouldIgnoreCase(string text, char mode)
    {
        Assert.That(mode, Is.EqualTo(ModeCharacterFinder.Find(text)));
    }

    [TestCase("ab", 'a')]
    [TestCase("ba", 'b')]
    public void ShouldReturnFirstModeCharacter(string text, char mode)
    {
        Assert.That(mode, Is.EqualTo(ModeCharacterFinder.Find(text)));
    }

    [TestCase("a", 'a')]
    [TestCase("aa", 'a')]
    [TestCase("abb", 'b')]
    [TestCase("Character", 'c')]
    public void ShouldReturnModeCharacter(string text, char mode)
    {
        Assert.That(mode, Is.EqualTo(ModeCharacterFinder.Find(text)));
    }
}