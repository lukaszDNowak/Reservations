using System;
using NUnit.Framework;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    public class FizzBuzzClassTests
    {
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void GetResultTest_ResultStringISOK(int number, string result)
        {
            var fizzBuzz = new FizzBuzzClass();
            Assert.That(fizzBuzz.GetResult(number), Is.EqualTo(result));
        }
        [Test]
        public void GetResultTest_ResultIsError()
        {
            var fizzBuzz = new FizzBuzzClass();
            Assert.That(() => fizzBuzz.GetResult(-1), Throws.ArgumentException);
        }
    }
}
