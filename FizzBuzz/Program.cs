using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public string GetResult(int number)
        {
            if (number < 0)
                throw new ArgumentException();
            string result = number.ToString();
            result = number % 3 == 0 ? "Fizz" : result;
            result = number % 5 == 0 ? "Buzz" : result;
            result = number % 3 == 0 && number % 5 == 0 ? "FizzBuzz" : result;
            return result;
        }
    }
}
