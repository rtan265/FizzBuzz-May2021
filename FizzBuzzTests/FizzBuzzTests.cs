using System;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(18)]
        [InlineData(21)]
        public void PrintFizz(int value)
        {
            string expected = "Fizz";

            var actual = "";

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        [InlineData(35)]
        [InlineData(40)]
        public void PrintBuzz(int value)
        {
            string expected = "Buzz";

            var actual = "";

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(60)]
        [InlineData(75)]
        [InlineData(90)]
        public void PrintFizzBuzz(int value)
        {
            string expected = "FizzBuzz";

            var actual = "";

            Assert.Equal(expected, actual);
        }
    }
}
