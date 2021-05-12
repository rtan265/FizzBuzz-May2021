using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FizzBuzzTests")]
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            fizzbuzz.StartFizzBuzz();
        }
    }
}
