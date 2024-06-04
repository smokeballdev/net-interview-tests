namespace Core;

internal static class BottleCalculator
{
    /// <summary>
    ///     Write a function to solve the following riddle:
    ///     Bottles of water cost $<see cref="waterUnitPrice" />
    ///     You can exchange either two bottle caps or four empty bottles for one free bottle of water
    ///     What is the maximum number of water bottles you can get with $<see cref="totalAmountInDollars" />
    /// </summary>
    internal static int GetMaximumNumberOfBottles(int waterUnitPrice, int totalAmountInDollars)
    {
        // Recursive solution.
        return GetBottlesRecursive(waterUnitPrice, totalAmountInDollars);

        // Iterative solution.
        return GetBottlesIterative(waterUnitPrice, totalAmountInDollars);
    }

    private static int GetBottlesIterative(int waterUnitPrice, int totalAmountInDollars)
    {
        var totalBottles = totalAmountInDollars / waterUnitPrice;
        var currentBottles = totalBottles;
        var currentCaps = totalBottles;
        while (currentBottles >= 4 || currentCaps >= 2)
        {
            var exchangedBottles = currentBottles / 4 + currentCaps / 2;
            currentBottles = currentBottles % 4 + exchangedBottles;
            currentCaps = currentCaps % 2 + exchangedBottles;
            totalBottles += exchangedBottles;
        }

        return totalBottles;
    }

    private static int GetBottlesRecursive(int waterUnitPrice, int totalAmountInDollars)
    {
        var totalBottles = totalAmountInDollars / waterUnitPrice;
        return totalBottles + ExchangeBottles(totalBottles, totalBottles);

        int ExchangeBottles(int bottles, int caps)
        {
            if (bottles < 4 && caps < 2)
            {
                return 0;
            }

            var exchangedBottles = bottles / 4 + caps / 2;
            return exchangedBottles + ExchangeBottles(exchangedBottles + bottles % 4, exchangedBottles + caps % 2);
        }
    }
}