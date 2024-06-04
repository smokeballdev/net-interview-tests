namespace Core;

internal static class SecretSantaManager
{
    /// Write an algorithm that, given a list of unique names, generates a list of random pairs A -> B (meaning: A gives a gift to B), meeting following constraints:
    /// 1. it’s secret (knowing an assignment does not reveal other pairs)
    /// 2. everybody receives exactly one gift
    /// 3. everybody gives exactly one gift
    /// 4. no selfies (A → A pairs)
    /// 5. it’s random
    public static IEnumerable<(string Sender, string Receiver)> GenerateSecretSantaList(IEnumerable<string> names)
    {
        var secretSantaMessages = new List<(string IChannelSender, string Receiver)>();
        var senders = names.ToList();
        for (var i = 0; i < senders.Count - 1; i++)
        {
            secretSantaMessages.Add((senders[i], senders[i + 1]));
        }

        secretSantaMessages.Add((senders[^1], senders[0]));
        return secretSantaMessages;
    }
}