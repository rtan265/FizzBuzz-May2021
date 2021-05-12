using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public NumberCheckingService _numberCheckingService;

        public FizzBuzz()
        {
            _numberCheckingService = new NumberCheckingService();
        }

        public void StartFizzBuzz()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(_numberCheckingService.CheckFizzBuzz(i));
            }
        }
    }
}
