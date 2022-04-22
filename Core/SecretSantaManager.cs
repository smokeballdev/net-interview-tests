using System.Collections.Generic;
using System.Linq;

namespace Core
{
    internal class SecretSantaManager
    {
        /// Write an algorithm that, given a list of unique names, generates a list of random pairs A -> B (meaning: A gives a gift to B), meeting following constraints:
        /// 1. it’s secret (knowing an assignment does not reveal other pairs)
        /// 2. everybody receives exactly one gift
        /// 3. everybody gives exactly one gift
        /// 4. no selfies (A → A pairs)
        /// 5. it’s random
        public static IEnumerable<(string Sender, string Receiver)> GenerateSecretSantaList(IEnumerable<string> names)
        {
            // Bug:
            // The logic tries to cheat by having each person giving gift to the next person, and the last person gives gift to the first person.
            // It violates rule 1, 4 and 5.
            var secretSantaMessages = new List<(string IChannelSender, string Receiver)>();
            var senders = names.ToList();
            for (var i = 0; i < senders.Count - 1; i++)
            {
                secretSantaMessages.Add((senders[i], senders[i + 1]));
            }

            secretSantaMessages.Add((senders[senders.Count - 1], senders[0]));
            return secretSantaMessages;
        }
    }
}