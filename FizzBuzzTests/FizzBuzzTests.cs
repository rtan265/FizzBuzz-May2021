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
        public void PrintBuzz(int value)
        {
            string expected = "FIZZ";

            var actual = "";

            Assert.Equal(expected, actual);
        }
    }
}
