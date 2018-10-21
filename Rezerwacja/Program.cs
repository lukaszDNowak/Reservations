using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezerwacja
{
    class Program
    {
        static void Main(string[] args)
        {
            Testy test = new Testy();
            Console.WriteLine(test.calculate(11));
            Console.ReadKey();

        }

    }
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            return (user.IsAdmin || MadeBy == user);
        }

    }
    public class User
    {
        public bool IsAdmin { get; set; }
    }

    public class Testy
    {
      
        public string calculate(int number)
        {
            string result;

            if (number % 3 == 0 && number % 5 == 0)
            {
                return result = "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return result = "Fizz";
            }
            if (number % 5 == 0)
            {
                return result = "Buzz";
            }
            if (number < 0)
            {
                throw new ArgumentException();
            }
            else return result = number.ToString();

            //if (number < 0)
            //    throw new ArgumentException();
            //string result = number.ToString();
            //result = number % 3 == 0 ? "Fizz" : result;
            //result = number % 5 == 0 ? "Buzz" : result;
            //result = number % 3 == 0 && number % 5 == 0 ? "FizzBuzz" : result;
            //return result;

        }
    }

}
