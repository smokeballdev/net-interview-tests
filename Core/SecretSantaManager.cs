namespace Core;

internal static class SecretSantaManager
{
    /// Write an algorithm that, given a list of unique names, generates a list of random pairs A -> B (meaning: A gives a gift to B), meeting following constraints:
    /// * it’s secret (knowing an assignment does not reveal other pairs)
    /// * everybody receives exactly one gift
    /// * everybody gives exactly one gift
    /// * no selfies (A → A pairs)
    /// * it’s random
    public static IEnumerable<(string Sender, string Receiver)> GenerateSecretSantaList(IEnumerable<string> names)
    {
        var random = new Random();
        var senders = names.ToList();

        if (senders.Count < 2)
        {
            yield break;
        }

        var receivers = new List<string>(senders);

        while (senders.Count > 0)
        {
            var count = senders.Count;
            if (count == 1)
            {
                yield return (senders[0], receivers[0]);
                yield break;
            }

            var i = random.Next(0, count);
            var sender = senders[i];
            var j = random.Next(0, count);
            while (j == i)
            {
                j = random.Next(0, count);
            }

            var receiver = receivers[j];
            senders.RemoveAt(i);
            receivers.RemoveAt(j);
            yield return (sender, receiver);
        }
    }
}