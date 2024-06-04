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
        return null;
    }
}