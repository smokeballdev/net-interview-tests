using Core;
using NUnit.Framework;

namespace Tests;

internal class WhenExpandingTemplates
{
    [Test]
    public void ShouldPopulateTemplate()
    {
        var dateTime = new DateTime(2000, 1, 1);
        var @enum = DateTimeKind.Local;
        Assert.That(
            TemplateExpander.PopulateTemplate(
                "Lorem ipsum {key1} sit amet, conse{key2}ctetur adipiscing {key3}, sed do {key4}{key5} ut labore et.",
                new Dictionary<string, object>
                {
                    { "key1", 11 },
                    { "key2", "cillum" },
                    { "key3", dateTime },
                    { "key4", @enum },
                    { "key5", 'c' }
                }),
            Is.EqualTo(
                $"Lorem ipsum {11} sit amet, conse{"cillum"}ctetur adipiscing {dateTime}, sed do {@enum}{'c'} ut labore et."));
    }
}