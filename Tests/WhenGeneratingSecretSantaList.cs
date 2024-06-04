using Core;
using NUnit.Framework;

namespace Tests;

internal class WhenGeneratingSecretSantaList
{
    [Test]
    public void ShouldGenerateEmptyList()
    {
        Assert.That(SecretSantaManager.GenerateSecretSantaList(Array.Empty<string>()), Is.Empty);
        Assert.That(SecretSantaManager.GenerateSecretSantaList(new[] { "name" }), Is.Empty);
    }

    [Test]
    public void ShouldGenerateSecretSantaList()
    {
        // Generate a random list of 5 to 10 names.
        var random = new Random();
        var names = Enumerable.Range(0, random.Next(5, 10))
            .Select(_ => new string(Enumerable.Range(0, random.Next(5, 10))
                .Select(__ => Convert.ToChar(random.Next(97, 122)))
                .ToArray()))
            .ToList();

        // Test 1: the generated secret Santa messages must be able to convert to a dictionary,
        //         because there can't be any duplicate senders.
        var secretSantaMessages = SecretSantaManager.GenerateSecretSantaList(names)
            .ToDictionary(x => x.Sender, x => x.Receiver);

        // Test 2: the generated secret Santa messages must not have any duplicate receivers.
        Assert.That(secretSantaMessages.Values.Distinct().Count(), Is.EqualTo(secretSantaMessages.Values.Count));

        // Test 3: the number of senders must be the same as the number of names.
        Assert.That(secretSantaMessages.Keys.Count, Is.EqualTo(names.Count));

        // Test 4: the number of receivers must be the same as the number of names.
        Assert.That(secretSantaMessages.Values.Count, Is.EqualTo(names.Count));
    }

    [Test]
    public void ShouldGenerateSimpleSantaList()
    {
        Assert.That(
            new[] { ("name 1", "name 2"), ("name 2", "name 1") }.SequenceEqual(SecretSantaManager
                .GenerateSecretSantaList(new[] { "name 1", "name 2" }).OrderBy(x => x)),
            Is.True);
    }
}