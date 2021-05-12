using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class NumberCheckingService
    {
        public int FIZZ { get; set; }
        public int BUZZ { get; set; }
        public int FIZZBUZZ { get; set; }

        public NumberCheckingService()
        {
            FIZZ = 3;
            BUZZ = 5;
            FIZZBUZZ = 15;
        }

        public NumberCheckingService(int fizz, int buzz, int fizzbuzz)
        {
            FIZZ = fizz;
            BUZZ = buzz;
            FIZZBUZZ = fizzbuzz;
        }

        public string CheckFizzBuzz(int i)
        {
            if (i % FIZZBUZZ == 0)
            {
                return "FizzBuzz";
            }
            else if (i % BUZZ == 0)
            {
                return "Buzz";
            }
            else if (i % FIZZ == 0)
            {
                return "Fizz";
            }
            else
            {
                return i.ToString();
            }
        }
    } 
}
