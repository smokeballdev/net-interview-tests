using Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class WhenReplacingNumbersWithFizzBuzz
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        public void ShouldReturnNumbers(int number, string result)
        {
            CollectionAssert.AreEqual(new[] { result }, FizzBuzzer.Generate(number, number));
        }

        [TestCase(3)]
        [TestCase(6)]
        public void ShouldReplaceMultiplesOf3WithFizz(int number)
        {
            CollectionAssert.AreEqual(new[] { "Fizz" }, FizzBuzzer.Generate(number, number));
        }

        [TestCase(5)]
        [TestCase(10)]
        public void ShouldReplaceMultiplesOf5WithBuzz(int number)
        {
            CollectionAssert.AreEqual(new[] { "Buzz" }, FizzBuzzer.Generate(number, number));
        }

        [TestCase(15)]
        [TestCase(30)]
        public void ShouldReplaceMultiplesOfBothWithFizzBuzz(int number)
        {
            CollectionAssert.AreEqual(new[] { "FizzBuzz" }, FizzBuzzer.Generate(number, number));
        }

        [TestCase]
        public void ShouldReturnFizzBuzzSequence()
        {
            var sequence = new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            CollectionAssert.AreEqual(sequence, FizzBuzzer.Generate(1, 15));
        }
    }
}
