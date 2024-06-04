using Core;
using NUnit.Framework;

namespace Tests;

public class WhenReplacingNumbersWithFizzBuzz
{
    [TestCase(3)]
    [TestCase(6)]
    public void ShouldReplaceMultiplesOf3WithFizz(int number)
    {
        Assert.That(new[] { "Fizz" }, Is.EquivalentTo(FizzBuzzer.Generate(number, number)));
    }

    [TestCase(5)]
    [TestCase(10)]
    public void ShouldReplaceMultiplesOf5WithBuzz(int number)
    {
        Assert.That(new[] { "Buzz" }, Is.EquivalentTo(FizzBuzzer.Generate(number, number)));
    }

    [TestCase(15)]
    [TestCase(30)]
    public void ShouldReplaceMultiplesOfBothWithFizzBuzz(int number)
    {
        Assert.That(new[] { "FizzBuzz" }, Is.EquivalentTo(FizzBuzzer.Generate(number, number)));
    }

    [TestCase]
    public void ShouldReturnFizzBuzzSequence()
    {
        var sequence = new[]
            { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

        Assert.That(sequence, Is.EquivalentTo(FizzBuzzer.Generate(1, 15)));
    }

    [TestCase(1, "1")]
    [TestCase(2, "2")]
    public void ShouldReturnNumbers(int number, string result)
    {
        Assert.That(new[] { result }, Is.EquivalentTo(FizzBuzzer.Generate(number, number)));
    }
}