namespace Core;

public class TemplateExpander
{
    /// <summary>
    ///     Write a function expanding templates in a simple template language (variables in curly braces).
    ///     For instance
    ///     Template:
    ///     Dear {name},
    ///     We have recently found out that we owe you {sum}. Could you please give us your bank account number in {country} so
    ///     that the funds can be disbursed?
    ///     Truly yours,
    ///     {signature}
    ///     Dictionary:
    ///     name → Jeremy
    ///     sum → $1000000
    ///     signature → The Prince
    /// </summary>
    public static string PopulateTemplate(string template, Dictionary<string, object> values)
    {
        var variableNames = values.Keys.ToList();
        var variableValues = values.Values.ToList();
        for (var i = 0; i < values.Count; i++)
        {
            // Bug: the "Replace" call doesn't store the replaced string.
            template.Replace("{" + variableNames[i] + "}", (string)variableValues[i]);
        }

        return template;
    }
}