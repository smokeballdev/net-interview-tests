using Core;
using NUnit.Framework;

namespace Tests
{
    public class WhenFindingModeCharacter
    {
        [TestCase("a", 'a')]
        [TestCase("aa", 'a')]
        [TestCase("abb", 'b')]
        public void ShouldReturnModeCharacter(string text, char mode)
        {
            Assert.AreEqual(mode, ModeCharacterFinder.Find(text));
        }

        [TestCase("Aab", 'a')]
        [TestCase("Baabb", 'b')]
        public void ShouldIgnoreCase(string text, char mode)
        {
            Assert.AreEqual(mode, ModeCharacterFinder.Find(text));
        }

        [TestCase("ab", 'a')]
        [TestCase("ba", 'b')]
        public void ShouldReturnFirstModeCharacter(string text, char mode)
        {
            Assert.AreEqual(mode, ModeCharacterFinder.Find(text));
        }
    }
}
