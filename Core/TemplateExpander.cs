﻿using System.Collections.Generic;

namespace Core;

public class TemplateExpander
{
    /// <summary>
    ///     Write a function expanding templates in a simple template language (variables in curly braces).
    ///     For instance
    ///     Template:
    ///     “Dear {name},
    ///     We have recently found out that we owe you {sum}. Could you please give us your bank account number in {country} so
    ///     that the funds can be disbursed.
    ///     Truly yours,
    ///     {signature}
    ///     Dictionary:
    ///     name → Jeremy
    ///     sum → $1000000
    ///     signature → The Prince
    /// </summary>
    public static void PopulateTemplate(string template, Dictionary<string, object> values)
    {
    }
}