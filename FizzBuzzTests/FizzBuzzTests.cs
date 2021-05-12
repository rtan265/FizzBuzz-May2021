using System;
using Xunit;
using FizzBuzz;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {
        NumberCheckingService _numberCheckingService = new FizzBuzz.NumberCheckingService();

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

            var actual = _numberCheckingService.CheckFizzBuzz(value);

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

            var actual = _numberCheckingService.CheckFizzBuzz(value);

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

            var actual = _numberCheckingService.CheckFizzBuzz(value);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(17)]
        [InlineData(19)]
        [InlineData(22)]
        public void PrintNumber(int value)
        {
            string expected = value.ToString();

            var actual = _numberCheckingService.CheckFizzBuzz(value);

            Assert.Equal(expected, actual);
        }
    }
}
